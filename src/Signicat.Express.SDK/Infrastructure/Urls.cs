namespace Signicat.Express.Infrastructure
{
    internal static class Urls
    {
        internal static string DefaultBaseUrl => "https://api.signicat.io";
        
        internal static string DefaultOAuthBaseUrl => $"{DefaultBaseUrl}/oauth";

        internal static string BaseUrl => SignicatConfiguration.BaseUrl;

        internal static string OAuthToken => $"{SignicatConfiguration.OAuthBaseUrl}/connect/token";

        internal static string Signature => $"{BaseUrl}/signature";

        internal static string SignatureDocuments => $"{Signature}/documents";

        internal static string Notification => $"{BaseUrl}/notification";

        internal static string MerchantSign => $"{BaseUrl}/merchant";
        
        internal static string Jwt => $"{BaseUrl}/jwt";

        internal static string Validation => $"{BaseUrl}/validation";

        internal static string Admin => $"{BaseUrl}/admin";

        internal static string Share => $"{BaseUrl}/share";

        internal static string Authentication => $"{BaseUrl}/identification/v2";
        
        internal static string Information => $"{BaseUrl}/information";
    }
}