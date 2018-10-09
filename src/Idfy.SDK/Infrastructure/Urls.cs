namespace Idfy.Infrastructure
{
    internal static class Urls
    {
        internal static string DefaultBaseUrl => "https://api.idfy.io";
        
        internal static string DefaultOAuthBaseUrl => BaseUrl;

        internal static string BaseUrl => IdfyConfiguration.BaseUrl;

        internal static string OAuthToken => $"{IdfyConfiguration.OAuthBaseUrl}/oauth/connect/token";

        internal static string Signature => $"{BaseUrl}/signature";

        internal static string SignatureDocuments => $"{Signature}/documents";

        internal static string Notification => $"{BaseUrl}/notification";
    }
}