namespace Idfy.Infrastructure
{
    internal static class Urls
    {
        internal static string DefaultBaseUrl => "https://api.idfy.io";
        
        internal static string DefaultOAuthBaseUrl => $"{DefaultBaseUrl}/oauth";

        internal static string BaseUrl => IdfyConfiguration.BaseUrl;

        internal static string OAuthToken => $"{IdfyConfiguration.OAuthBaseUrl}/connect/token";

        internal static string Signature => $"{BaseUrl}/signature";

        internal static string SignatureDocuments => $"{Signature}/documents";

        internal static string Notification => $"{BaseUrl}/notification";

        internal static string Identification => $"{BaseUrl}/identification";

        internal static string MerchantSign => $"{BaseUrl}/merchant";
        
        internal static string Jwt => $"{BaseUrl}/jwt";

        internal static string Validation => $"{BaseUrl}/validation";

        internal static string Admin => $"{BaseUrl}/admin";

        internal static string Share => $"{BaseUrl}/share";

        internal static string IdentificationV2 => $"{BaseUrl}/identification/v2";
        internal static string Addons => $"{BaseUrl}/information";
    }
}