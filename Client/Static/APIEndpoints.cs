namespace Client.Static;

internal static class APIEndpoints
{
#if DEBUG
    internal const string ServerBaseUrl = "https://localhost:7117";
#else
    internal const string ServerBaseUrl = "https://denvercoderblogapi.azurewebsites.net";
#endif

    internal readonly static string s_categories = $"{ServerBaseUrl}/api/categories";
}

