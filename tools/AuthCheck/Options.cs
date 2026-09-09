namespace Arbor.Tools.AuthCheck;

internal sealed class OptionsException(string message) : Exception(message);

internal sealed class Options
{
    public string? BaseUrl { get; private set; }

    /// <summary>The Arbor API applicationUsername.</summary>
    public string? ApplicationUsername { get; private set; }

    /// <summary>The Arbor API dpt_token, sent as the HTTP Basic password.</summary>
    public string? DptToken { get; private set; }

    /// <summary>Raw --resource input; resolved against the SDK's ResourceType.</summary>
    public string Resource { get; private set; } = global::Arbor.Resource.ResourceType.STUDENT;

    public bool ListResources { get; private set; }

    /// <summary>Optional substring filter for --list-resources.</summary>
    public string? ResourceFilter { get; private set; }

    public int PageSize { get; private set; } = 1;

    public int TimeoutSeconds { get; private set; } = 30;

    public bool Verbose { get; private set; }

    public bool ShowHelp { get; private set; }

    public const string HelpText = """
        arbor-auth-check - test Arbor API authentication through the SDK gateway

        Issues a GET via Arbor.Api.Gateway.RestGateway, the same gateway class
        integrators use, so a pass proves the SDK authenticates. Reads /students
        by default; use --resource for any other entity.

        Usage:
          dotnet run --project tools/AuthCheck -- [options]

        Options:
          --url <url>         Arbor site base URL, e.g. https://myschool.uk.arbor.sc
                              Omit /rest-v2; it is added for you.
          --resource <name>   Entity to read. Default Student. Accepts the SDK name
                              (Student), the constant (STUDENT) or the URL segment
                              (students). Aliases: --entity, -r
          --list-resources    List all resource types the SDK defines and exit.
                              Takes an optional search term, e.g.
                              --list-resources attendance
          --application-username <name>
                              Arbor API applicationUsername.
          --dpt-token <token> Arbor API dpt_token. Omit to be prompted for it
                              without echo, which keeps it out of shell history.
          --page-size <n>     Records to request. Default 1, which is enough to
                              prove authentication without pulling real data.
          --timeout <s>       Give up waiting after this many seconds. Default 30.
                              The SDK sets no timeout of its own.
          --verbose           Show returned resource URLs and full exception detail.
          --help              Show this help.

        The two credential flags also accept their verbatim Arbor spellings,
        --applicationUsername and --dpt_token, so either form can be pasted in.

        Environment variables (used when the matching option is omitted):
          ARBOR_API_URL, ARBOR_APPLICATION_USERNAME, ARBOR_DPT_TOKEN

        Exit codes:
          0  authenticated successfully
          1  authentication failed (401) or authorisation refused (403)
          2  bad usage or missing configuration
          3  network, DNS, TLS or timeout failure
          4  reached the API but the request was refused (404, 5xx, or an error
             the SDK did not report a status for)

        Examples:
          # Prompt for the dpt_token:
          dotnet run --project tools/AuthCheck -- --url https://myschool.uk.arbor.sc \
            --application-username my-application

          # Check a different entity:
          dotnet run --project tools/AuthCheck -- --url https://myschool.uk.arbor.sc \
            --application-username my-application --resource Staff

          # Find the name of an entity:
          dotnet run --project tools/AuthCheck -- --list-resources enrolment

          # Fully non-interactive, for a script:
          ARBOR_API_URL=https://myschool.uk.arbor.sc \
          ARBOR_APPLICATION_USERNAME=my-application \
          ARBOR_DPT_TOKEN=... \
          dotnet run --project tools/AuthCheck
        """;

    public static Options Parse(string[] args)
    {
        var options = new Options();

        for (var i = 0; i < args.Length; i++)
        {
            var argument = args[i];

            // Accept both "--flag value" and "--flag=value".
            string? inlineValue = null;
            var separator = argument.IndexOf('=');

            if (argument.StartsWith("--", StringComparison.Ordinal) && separator > 0)
            {
                inlineValue = argument[(separator + 1)..];
                argument = argument[..separator];
            }

            switch (argument)
            {
                case "--url":
                    options.BaseUrl = TakeValue(args, ref i, inlineValue, argument);
                    break;

                // Both the kebab-case CLI spelling and the verbatim Arbor
                // identifier are accepted, so either can be copied straight in.
                case "--application-username":
                case "--applicationUsername":
                    options.ApplicationUsername = TakeValue(args, ref i, inlineValue, argument);
                    break;

                case "--dpt-token":
                case "--dpt_token":
                    options.DptToken = TakeValue(args, ref i, inlineValue, argument);
                    break;

                case "--resource":
                case "--entity":
                case "-r":
                    options.Resource = TakeValue(args, ref i, inlineValue, argument);
                    break;

                case "--list-resources":
                case "--list-entities":
                    options.ListResources = true;
                    // The filter is optional, so only consume the next argument
                    // when it is not another option.
                    options.ResourceFilter = inlineValue ?? TakeOptionalValue(args, ref i);
                    break;

                case "--page-size":
                    options.PageSize = TakePositiveInt(args, ref i, inlineValue, argument);
                    break;

                case "--timeout":
                    options.TimeoutSeconds = TakePositiveInt(args, ref i, inlineValue, argument);
                    break;

                case "--verbose":
                case "-v":
                    options.Verbose = true;
                    break;

                case "--help":
                case "-h":
                    options.ShowHelp = true;
                    break;

                default:
                    throw new OptionsException("unknown option '" + argument + "'.");
            }
        }

        return options;
    }

    private static string? TakeOptionalValue(string[] args, ref int index)
    {
        if (index + 1 >= args.Length || args[index + 1].StartsWith("--", StringComparison.Ordinal))
        {
            return null;
        }

        return args[++index];
    }

    private static string TakeValue(string[] args, ref int index, string? inlineValue, string name)
    {
        if (inlineValue is not null)
        {
            return inlineValue;
        }

        if (index + 1 >= args.Length)
        {
            throw new OptionsException(name + " requires a value.");
        }

        return args[++index];
    }

    private static int TakePositiveInt(string[] args, ref int index, string? inlineValue, string name)
    {
        var raw = TakeValue(args, ref index, inlineValue, name);

        if (!int.TryParse(raw, out var value) || value <= 0)
        {
            throw new OptionsException(name + " requires a positive whole number, got '" + raw + "'.");
        }

        return value;
    }
}
