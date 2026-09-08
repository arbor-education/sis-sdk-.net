using Arbor.Filter;
using System.Reflection;

namespace Arbor.Tools.AuthCheck;

/// <summary>
/// One resource type the SDK knows about.
/// </summary>
/// <param name="ConstantName">Field name, e.g. ACADEMIC_UNIT.</param>
/// <param name="Value">Value the gateway expects, e.g. AcademicUnit.</param>
/// <param name="UrlSegment">Path the gateway derives, e.g. academic-units.</param>
/// <param name="Container">Declaring class, e.g. Arbor.Resource.ResourceType.</param>
/// <param name="ModelType">
/// The model class the gateway will hydrate records into, or null if the SDK
/// defines the resource but ships no model for it. Only module resources (those
/// with an underscore) actually break in that case; for the rest RestGateway
/// falls back to ModelBase.
/// </param>
internal sealed record ResourceEntry(
    string ConstantName, string Value, string UrlSegment, string Container, Type? ModelType)
{
    public bool IsModuleResource => Value.Contains('_', StringComparison.Ordinal);

    /// <summary>
    /// True when a returned record would crash the gateway's model instantiation.
    /// </summary>
    public bool WillFailToHydrate => ModelType is null && IsModuleResource;
}

/// <summary>
/// The set of resource types available to --resource, read by reflection from
/// the SDK's own ResourceType classes rather than hard-coded here. Any resource
/// added to the SDK becomes usable without touching this tool.
/// </summary>
internal static class ResourceCatalog
{
    private static readonly Lazy<List<ResourceEntry>> Entries = new(Discover);

    public static IReadOnlyList<ResourceEntry> All => Entries.Value;

    private static List<ResourceEntry> Discover()
    {
        var pluralize = new PluralizeFilter();
        var camelCaseToDash = new CamelCaseToDash();
        var discovered = new List<ResourceEntry>();

        // Arbor.Resource.ResourceType plus the per-module ones
        // (Arbor.Resource.UkDfe, Arbor.Resource.Finance, and any added later).
        var containers = typeof(global::Arbor.Resource.ResourceType).Assembly
            .GetTypes()
            .Where(type => type.Name == "ResourceType"
                && type.Namespace?.StartsWith("Arbor.Resource", StringComparison.Ordinal) == true)
            .OrderBy(type => type.FullName, StringComparer.Ordinal);

        foreach (var container in containers)
        {
            var constants = container
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(field => field.IsLiteral && field.FieldType == typeof(string));

            foreach (var constant in constants)
            {
                if (constant.GetRawConstantValue() is not string value || value.Length == 0)
                {
                    continue;
                }

                // Mirrors RestGateway.query's URL composition.
                var segment = camelCaseToDash.filter(pluralize.filter(value)).ToLowerInvariant();

                discovered.Add(new ResourceEntry(
                    constant.Name, value, segment, container.FullName ?? container.Name,
                    FindModelType(value)));
            }
        }

        // The same value can be declared in more than one container; the gateway
        // only cares about the value, so keep one entry per distinct value.
        return discovered
            .GroupBy(entry => entry.Value, StringComparer.Ordinal)
            .Select(group => group.First())
            .OrderBy(entry => entry.Value, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    /// <summary>
    /// Resolves the model class exactly as RestGateway.instantiateModel does.
    /// The lookup must be made against the SDK's assembly: the gateway calls
    /// Type.GetType from inside it, whereas this code lives elsewhere and would
    /// otherwise always get null.
    /// </summary>
    private static Type? FindModelType(string value)
    {
        var sdkAssembly = typeof(global::Arbor.Model.ModelBase).Assembly;

        if (value.Contains('_', StringComparison.Ordinal))
        {
            var parts = value.Split('_');
            return sdkAssembly.GetType("Arbor.Model." + parts[0] + "." + parts[1]);
        }

        return sdkAssembly.GetType("Arbor.Model." + value);
    }

    /// <summary>
    /// Resolves whatever the user typed to a resource type value. Accepts the
    /// value ("Student"), the constant name ("STUDENT"), the URL segment
    /// ("students"), and near-misses differing only in separators or case.
    /// </summary>
    public static bool TryResolve(string input, out ResourceEntry resolved, out string error)
    {
        resolved = null!;
        error = string.Empty;

        var candidate = input.Trim();

        if (candidate.Length == 0)
        {
            error = "--resource needs a value. Use --list-resources to see the options.";
            return false;
        }

        // Progressively looser matching, so an exact hit always wins.
        var matched =
            Match(entry => entry.Value.Equals(candidate, StringComparison.OrdinalIgnoreCase))
            ?? Match(entry => entry.ConstantName.Equals(candidate, StringComparison.OrdinalIgnoreCase))
            ?? Match(entry => entry.UrlSegment.Equals(candidate, StringComparison.OrdinalIgnoreCase));

        if (matched is not null)
        {
            resolved = matched;
            return true;
        }

        // Fall back to ignoring separators, so "academic unit", "academic-unit"
        // and "academicunit" all land on AcademicUnit.
        var normalised = Normalise(candidate);

        var loose = All
            .Where(entry => Normalise(entry.Value) == normalised
                || Normalise(entry.ConstantName) == normalised
                || Normalise(entry.UrlSegment) == normalised)
            .ToList();

        if (loose.Count == 1)
        {
            resolved = loose[0];
            return true;
        }

        if (loose.Count > 1)
        {
            error = "'" + input + "' is ambiguous. Did you mean one of: "
                + string.Join(", ", loose.Take(6).Select(entry => entry.Value)) + "?";
            return false;
        }

        error = BuildUnknownResourceError(input, normalised);
        return false;
    }

    private static ResourceEntry? Match(Func<ResourceEntry, bool> predicate)
        => All.FirstOrDefault(predicate);

    private static string BuildUnknownResourceError(string input, string normalised)
    {
        var message = "'" + input + "' is not a resource type the SDK defines.";

        // Substring matching in both directions catches "student" -> Student,
        // StudentNote, ... and "academicunitenrolment" -> AcademicUnitEnrolment.
        var suggestions = All
            .Where(entry => Normalise(entry.Value).Contains(normalised, StringComparison.Ordinal)
                || normalised.Contains(Normalise(entry.Value), StringComparison.Ordinal))
            .Select(entry => entry.Value)
            .Take(8)
            .ToList();

        if (suggestions.Count > 0)
        {
            message += " Close matches: " + string.Join(", ", suggestions) + ".";
        }

        return message + " Use --list-resources to see all "
            + All.Count.ToString() + ", or --list-resources <text> to search.";
    }

    /// <summary>
    /// Strips the separators that distinguish the constant, value and URL forms
    /// of the same name, so they compare equal.
    /// </summary>
    private static string Normalise(string text)
        => new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLowerInvariant();

    /// <summary>
    /// Lists resource types, optionally filtered by a substring, as
    /// "Value  ->  url-segment".
    /// </summary>
    public static void Write(string? filter)
    {
        var normalisedFilter = filter is null ? null : Normalise(filter);

        var listed = normalisedFilter is null
            ? All
            : All.Where(entry => Normalise(entry.Value).Contains(normalisedFilter, StringComparison.Ordinal)
                || Normalise(entry.ConstantName).Contains(normalisedFilter, StringComparison.Ordinal))
                .ToList();

        if (listed.Count == 0)
        {
            Console.WriteLine("No resource type matches '" + filter + "'.");
            return;
        }

        Console.WriteLine(filter is null
            ? "Resource types the SDK defines (" + listed.Count + "):"
            : "Resource types matching '" + filter + "' (" + listed.Count + " of " + All.Count + "):");
        Console.WriteLine();

        var width = listed.Max(entry => entry.Value.Length);

        foreach (var entry in listed)
        {
            Console.WriteLine("  " + entry.Value.PadRight(width) + "  ->  /rest-v2/" + entry.UrlSegment
                + (entry.WillFailToHydrate ? "   [no model class]" : string.Empty));
        }

        Console.WriteLine();

        if (listed.Any(entry => entry.WillFailToHydrate))
        {
            Console.WriteLine("[no model class] the SDK defines the resource but ships no model for it.");
            Console.WriteLine("Authentication can still be checked; reading records back cannot.");
            Console.WriteLine();
        }
        Console.WriteLine("Pass any of these to --resource, e.g. --resource " + listed[0].Value);
        Console.WriteLine("The URL segment or the SDK constant name (e.g. "
            + listed[0].ConstantName + ") are also accepted.");
    }
}
