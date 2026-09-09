using Arbor.Api;
using Arbor.Api.Gateway;
using Arbor.Filter;
using Arbor.Model;
using Arbor.Query;
using System.Diagnostics;

namespace Arbor.Tools.AuthCheck;

/// <summary>
/// Checks that a set of Arbor API credentials can authenticate against a single
/// GET endpoint, /students, by driving the SDK's own RestGateway.
///
/// The request is issued by RestGateway.query, so this exercises the real
/// gateway code path: its Basic auth header, its headers, its URL composition
/// and its error handling. A pass means the SDK itself authenticates, not merely
/// that the credentials are valid.
/// </summary>
internal static class Program
{
    // Exit codes, so this can be used as a scripted/CI check.
    private const int ExitPass = 0;
    private const int ExitAuthFailed = 1;
    private const int ExitUsage = 2;
    private const int ExitNetwork = 3;
    private const int ExitUnexpected = 4;

    private static int Main(string[] args)
    {
        Options options;

        try
        {
            options = Options.Parse(args);
        }
        catch (OptionsException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            Console.Error.WriteLine("Run with --help for usage.");
            return ExitUsage;
        }

        if (options.ShowHelp)
        {
            Console.WriteLine(Options.HelpText);
            return ExitPass;
        }

        if (options.ListResources)
        {
            ResourceCatalog.Write(options.ResourceFilter);
            return ExitPass;
        }

        if (!ResourceCatalog.TryResolve(options.Resource, out var resource, out var resourceError))
        {
            Console.Error.WriteLine("Error: " + resourceError);
            return ExitUsage;
        }

        if (!TryResolveCredentials(
                options, out var baseUrl, out var applicationUsername, out var dptToken))
        {
            return ExitUsage;
        }

        var exitCode = RunCheck(options, resource, baseUrl, applicationUsername, dptToken);

        Console.WriteLine();
        Console.WriteLine(exitCode == ExitPass ? "PASS" : "FAIL  (exit " + exitCode + ")");

        // Exit explicitly: on timeout the gateway's request thread is abandoned
        // still waiting on the socket, and would otherwise hold the process open.
        Console.Out.Flush();
        Environment.Exit(exitCode);
        return exitCode;
    }

    private static int RunCheck(
        Options options, ResourceEntry resource, string baseUrl,
        string applicationUsername, string dptToken)
    {
        // The subject under test, constructed exactly as an integrator would.
        // RestGateway names its parameters authUser/authPassword; Arbor issues
        // those two values as an applicationUsername and a dpt_token, which is
        // what they are called throughout this tool.
        var gateway = new RestGateway(baseUrl, applicationUsername, dptToken);

        var query = new SimpleQuery(resource.Value);
        query.setPageSize(options.PageSize);

        Console.WriteLine();
        Console.WriteLine("Gateway:  Arbor.Api.Gateway.RestGateway  (SDK version " + SdkVersion() + ")");
        Console.WriteLine("Resource: " + resource.Value + "  (" + resource.ConstantName + ")");
        Console.WriteLine("GET       " + DescribeRequestUrl(baseUrl, query));
        Console.WriteLine("Auth:     HTTP Basic, applicationUsername '" + applicationUsername + "'");

        if (resource.WillFailToHydrate)
        {
            Console.WriteLine();
            Console.WriteLine("Note:     the SDK ships no model class for this resource");
            Console.WriteLine("          (Arbor.Model." + resource.Value.Replace('_', '.') + " does not exist), so");
            Console.WriteLine("          authentication can be checked but records cannot be read back.");
        }

        Console.WriteLine();

        var stopwatch = Stopwatch.StartNew();

        try
        {
            var records = QueryWithTimeout(gateway, query, options.TimeoutSeconds);
            stopwatch.Stop();

            if (records is null)
            {
                Report("TIMEOUT", "the gateway returned nothing within " + options.TimeoutSeconds + "s.");
                Console.WriteLine("  Check the base URL, and whether a VPN or proxy is needed to reach it.");
                Console.WriteLine("  Note the SDK sets no request timeout of its own, so a wedged");
                Console.WriteLine("  connection would otherwise hang indefinitely.");
                return ExitNetwork;
            }

            Console.WriteLine("  Completed in " + FormatDuration(stopwatch.Elapsed));
            Console.WriteLine();
            Report("AUTH OK", "the gateway authenticated and read /" + resource.UrlSegment + ".");
            Console.WriteLine("  Returned " + records.Count + " " + resource.Value + " record(s).");

            if (options.Verbose)
            {
                PrintResourceUrls(records);
            }

            return ExitPass;
        }
        catch (ServerErrorException ex)
        {
            stopwatch.Stop();
            return ReportServerError(ex, resource, options);
        }
        catch (ArgumentNullException) when (resource.WillFailToHydrate)
        {
            // RestGateway.instantiateModel passes the result of Type.GetType
            // straight to Activator.CreateInstance without a null check, so a
            // resource with no model class throws here. This happens only after
            // a 2xx response containing the expected JSON key, so authentication
            // has already succeeded.
            stopwatch.Stop();
            Report("AUTH OK, CANNOT MODEL RESOURCE",
                "the gateway authenticated, but could not build objects from the result.");
            Console.WriteLine("  The API returned records for /" + resource.UrlSegment + ", so the");
            Console.WriteLine("  credentials are good. The SDK then failed to instantiate them because");
            Console.WriteLine("  it defines no Arbor.Model." + resource.Value.Replace('_', '.') + " class.");
            Console.WriteLine();
            Console.WriteLine("  Treating this as an authentication pass. Reading this resource through");
            Console.WriteLine("  the SDK needs a model class adding first.");
            return ExitPass;
        }
        catch (Newtonsoft.Json.JsonReaderException ex)
        {
            stopwatch.Stop();
            Report("NOT THE API", "the server replied, but not with JSON.");
            Console.WriteLine("  The gateway could not parse the response, which usually means the base");
            Console.WriteLine("  URL served a web page rather than the REST API. A sign-in or SSO page");
            Console.WriteLine("  in front of the site does this, and can return HTTP 200.");
            Console.WriteLine();
            Console.WriteLine("  Authentication could not be confirmed either way. Check --url is the");
            Console.WriteLine("  Arbor site root and that the API is enabled for it.");
            PrintGatewayMessage(ex.Message);
            return ExitUnexpected;
        }
        catch (NullReferenceException)
        {
            // RestGateway.sendRequest dereferences WebException.Response without a
            // null check, so a connection-level failure (DNS, refused, TLS) throws
            // here instead of reporting the real cause. See the README.
            stopwatch.Stop();
            Report("NETWORK FAILURE", "the connection failed before any HTTP response arrived.");
            Console.WriteLine("  Likely causes: the host in the base URL does not resolve, the");
            Console.WriteLine("  connection was refused, or TLS negotiation failed.");
            Console.WriteLine();
            Console.WriteLine("  A redirect can also land here: the gateway follows one redirect, so an");
            Console.WriteLine("  unreachable redirect target fails this way. Cross-host redirects also");
            Console.WriteLine("  drop the Authorization header, which then looks like a 401.");
            Console.WriteLine();
            Console.WriteLine("  The gateway surfaced this as a NullReferenceException rather than a");
            Console.WriteLine("  useful message, because RestGateway.sendRequest reads");
            Console.WriteLine("  WebException.Response without checking it for null.");
            return ExitNetwork;
        }
        catch (Exception ex)
        {
            stopwatch.Stop();
            Report("UNEXPECTED ERROR", ex.GetType().Name + ": " + ex.Message);

            if (options.Verbose)
            {
                Console.WriteLine();
                Console.WriteLine("  " + ex);
            }

            return ExitUnexpected;
        }
    }

    /// <summary>
    /// Runs the gateway call on a worker thread so a hung connection can be
    /// reported. The SDK exposes no timeout and the underlying request cannot be
    /// cancelled, so on expiry the worker is abandoned and Main exits the process.
    /// Returns null on timeout.
    /// </summary>
    private static ModelCollection<ModelBase>? QueryWithTimeout(
        RestGateway gateway, SimpleQuery query, int timeoutSeconds)
    {
        ModelCollection<ModelBase>? result = null;
        Exception? failure = null;

        var worker = new Thread(() =>
        {
            try
            {
                result = gateway.query(query);
            }
            catch (Exception ex)
            {
                failure = ex;
            }
        })
        {
            IsBackground = true,
        };

        worker.Start();

        if (!worker.Join(TimeSpan.FromSeconds(timeoutSeconds)))
        {
            return null;
        }

        if (failure is not null)
        {
            // Rethrown on the main thread for the handlers in RunCheck, keeping
            // the original stack trace intact.
            System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(failure).Throw();
        }

        return result;
    }

    /// <summary>
    /// Interprets the gateway's error. ServerErrorException carries only a
    /// message, with no status code or inner exception, so the HTTP status has to
    /// be recovered from the text. Where it cannot be, the message is reported
    /// verbatim rather than guessed at.
    /// </summary>
    private static int ReportServerError(
        ServerErrorException ex, ResourceEntry resource, Options options)
    {
        var message = ex.Message ?? string.Empty;
        var haystack = message.ToLowerInvariant();

        if (Mentions(haystack, "(401)", "unauthorized", "unauthorised", "invalid credentials", "bad credentials"))
        {
            Report("AUTH FAILED", "the gateway's credentials were rejected (401).");
            Console.WriteLine("  Check the applicationUsername and dpt_token, and that the");
            Console.WriteLine("  application is enabled for this Arbor site.");
            PrintGatewayMessage(message);
            return ExitAuthFailed;
        }

        if (Mentions(haystack, "(403)", "forbidden", "access denied", "not permitted"))
        {
            Report("AUTHENTICATED, NOT AUTHORISED", "the credentials are valid but lack permission (403).");
            Console.WriteLine("  Authentication itself succeeded. Grant the application access to");
            Console.WriteLine("  this data in Arbor, then re-run.");
            PrintGatewayMessage(message);
            return ExitAuthFailed;
        }

        if (Mentions(haystack, "(404)", "not found"))
        {
            Report("NOT FOUND", "the endpoint does not exist at this base URL (404).");
            Console.WriteLine("  The credentials may be fine. Check --url points at the Arbor site");
            Console.WriteLine("  root, with no /rest-v2 suffix, and that this API exposes");
            Console.WriteLine("  /rest-v2/" + resource.UrlSegment + " as a listable collection.");
            PrintGatewayMessage(message);
            return ExitUnexpected;
        }

        if (Mentions(haystack, "(500)", "(502)", "(503)", "(504)", "internal server error"))
        {
            Report("SERVER ERROR", "the API failed to serve the request.");
            Console.WriteLine("  This is not a credentials problem. Retry, then escalate if it persists.");
            PrintGatewayMessage(message);
            return ExitUnexpected;
        }

        if (Mentions(haystack, "timed out", "timeout", "could not be resolved", "no such host", "connection"))
        {
            Report("NETWORK FAILURE", "the gateway could not complete the request.");
            PrintGatewayMessage(message);
            return ExitNetwork;
        }

        Report("REQUEST REJECTED", "the gateway raised ServerErrorException.");
        Console.WriteLine("  The status code could not be determined: the SDK's exception carries");
        Console.WriteLine("  only this message.");
        PrintGatewayMessage(message);

        if (options.Verbose)
        {
            Console.WriteLine();
            Console.WriteLine("  " + ex);
        }

        return ExitUnexpected;
    }

    private static bool Mentions(string haystack, params string[] needles)
        => needles.Any(needle => haystack.Contains(needle, StringComparison.Ordinal));

    /// <summary>
    /// Reproduces the URL for display using the SDK's own filters and query
    /// builder, so what is printed matches what the gateway requests.
    /// </summary>
    private static string DescribeRequestUrl(string baseUrl, SimpleQuery query)
    {
        var pluralize = new PluralizeFilter();
        var camelCaseToDash = new CamelCaseToDash();

        var resource = camelCaseToDash.filter(pluralize.filter(query.getResourceType())).ToLowerInvariant();
        var url = baseUrl + "/rest-v2/" + resource;
        var queryString = query.getQueryString();

        return queryString.Length > 0 ? url + "?" + queryString : url;
    }

    private static string SdkVersion()
    {
        var attribute = typeof(RestGateway).Assembly
            .GetCustomAttributes(typeof(System.Reflection.AssemblyInformationalVersionAttribute), false)
            .OfType<System.Reflection.AssemblyInformationalVersionAttribute>()
            .FirstOrDefault();

        return string.IsNullOrEmpty(attribute?.InformationalVersion)
            ? typeof(RestGateway).Assembly.GetName().Version?.ToString() ?? "unknown"
            : attribute!.InformationalVersion;
    }

    /// <summary>
    /// Lists resource URLs only. Enough to prove real records came back without
    /// printing student personal data.
    /// </summary>
    private static void PrintResourceUrls(ModelCollection<ModelBase> records)
    {
        Console.WriteLine();
        Console.WriteLine("  Resource URLs returned:");

        foreach (ModelBase record in records)
        {
            Console.WriteLine("    " + (record.getResourceUrl()?.OriginalString ?? "(no href)"));
        }
    }

    private static bool TryResolveCredentials(
        Options options, out string baseUrl, out string applicationUsername, out string dptToken)
    {
        baseUrl = string.Empty;
        applicationUsername = string.Empty;
        dptToken = string.Empty;

        var rawUrl = options.BaseUrl ?? Environment.GetEnvironmentVariable("ARBOR_API_URL");

        var rawUsername = options.ApplicationUsername
            ?? Environment.GetEnvironmentVariable("ARBOR_APPLICATION_USERNAME");

        var rawToken = options.DptToken
            ?? Environment.GetEnvironmentVariable("ARBOR_DPT_TOKEN");

        if (string.IsNullOrWhiteSpace(rawUrl))
        {
            Console.Error.WriteLine("Error: no base URL. Pass --url or set ARBOR_API_URL.");
            return false;
        }

        if (!TryNormaliseBaseUrl(rawUrl, out baseUrl, out var urlError))
        {
            Console.Error.WriteLine("Error: " + urlError);
            return false;
        }

        if (string.IsNullOrWhiteSpace(rawUsername))
        {
            Console.Error.WriteLine("Error: no applicationUsername. Pass --application-username"
                + " or set ARBOR_APPLICATION_USERNAME.");
            return false;
        }

        // Prompting keeps the dpt_token out of shell history and `ps` output.
        rawToken ??= ReadDptToken();

        if (string.IsNullOrEmpty(rawToken))
        {
            Console.Error.WriteLine("Error: no dpt_token supplied.");
            return false;
        }

        applicationUsername = rawUsername.Trim();
        dptToken = rawToken;
        return true;
    }

    /// <summary>
    /// Accepts the base URL in the forms people actually type: with or without a
    /// scheme, a trailing slash, or a /rest-v2 suffix. RestGateway concatenates
    /// "/rest-v2/..." onto whatever it is given, so it must be handed a bare root.
    /// </summary>
    internal static bool TryNormaliseBaseUrl(string raw, out string baseUrl, out string error)
    {
        baseUrl = string.Empty;
        error = string.Empty;

        var candidate = raw.Trim();

        if (!candidate.Contains("://", StringComparison.Ordinal))
        {
            candidate = "https://" + candidate;
        }

        candidate = candidate.TrimEnd('/');

        const string restPrefix = "/rest-v2";
        var restIndex = candidate.IndexOf(restPrefix, StringComparison.OrdinalIgnoreCase);

        if (restIndex >= 0)
        {
            candidate = candidate[..restIndex].TrimEnd('/');
        }

        if (!Uri.TryCreate(candidate, UriKind.Absolute, out var parsed))
        {
            error = "'" + raw + "' is not a valid URL.";
            return false;
        }

        if (parsed.Scheme != Uri.UriSchemeHttps && parsed.Scheme != Uri.UriSchemeHttp)
        {
            error = "the base URL must use http or https, not '" + parsed.Scheme + "'.";
            return false;
        }

        baseUrl = candidate;
        return true;
    }

    private static string ReadDptToken()
    {
        Console.Error.Write("dpt_token (not echoed): ");

        // No interactive console when input is piped or redirected.
        if (Console.IsInputRedirected)
        {
            var piped = Console.ReadLine();
            Console.Error.WriteLine();
            return piped ?? string.Empty;
        }

        var buffer = new System.Text.StringBuilder();

        while (true)
        {
            var key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }

            if (key.Key == ConsoleKey.Backspace)
            {
                if (buffer.Length > 0)
                {
                    buffer.Length--;
                }

                continue;
            }

            if (!char.IsControl(key.KeyChar))
            {
                buffer.Append(key.KeyChar);
            }
        }

        Console.Error.WriteLine();
        return buffer.ToString();
    }

    private static void PrintGatewayMessage(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            return;
        }

        Console.WriteLine();
        Console.WriteLine("  Gateway message:");

        foreach (var line in message.Split('\n'))
        {
            Console.WriteLine("    " + line.TrimEnd('\r'));
        }
    }

    private static void Report(string label, string detail)
    {
        Console.WriteLine("  " + label + "  -  " + detail);
        Console.WriteLine();
    }

    private static string FormatDuration(TimeSpan elapsed)
        => elapsed.TotalSeconds >= 1
            ? elapsed.TotalSeconds.ToString("0.0") + "s"
            : elapsed.TotalMilliseconds.ToString("0") + "ms";
}
