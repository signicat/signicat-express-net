using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Signicat.Express.Infrastructure;

namespace Signicat.Express
{
    public static class IdfyConfiguration
    {
        private static string _baseUrl;
        private static string _oauthBaseUrl;

        /// <summary>
        /// Sets the OAuth client credentials and scopes.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <param name="clientSecret">Client secret.</param>
        /// <param name="scopes">Scopes.</param>
        public static void SetClientCredentials(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scopes = scopes.Select(s => s.ToEnumMemberString());
        }
        
        /// <summary>
        /// Sets the OAuth client credentials and scopes.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <param name="clientSecret">Client secret.</param>
        /// <param name="scopes">Scopes.</param>
        public static void SetClientCredentials(string clientId, string clientSecret, IEnumerable<string> scopes)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scopes = scopes;
        }
        
        /// <summary>
        /// Lets you provide your own <see cref="HttpClient"/>.
        /// </summary>
        public static HttpClient HttpClient { get; set; }
        
        /// <summary>
        /// Gets or sets the Idfy API base URL.
        /// </summary>
        public static string BaseUrl
        {
            get => string.IsNullOrWhiteSpace(_baseUrl) ? Urls.DefaultBaseUrl : _baseUrl;
            set => _baseUrl = value;
        }

        /// <summary>
        /// Gets or sets the Idfy OAuth base URL.
        /// </summary>
        public static string OAuthBaseUrl
        {
            get => string.IsNullOrWhiteSpace(_oauthBaseUrl) ? Urls.DefaultOAuthBaseUrl : _oauthBaseUrl;
            set => _oauthBaseUrl = value;
        }

        /// <summary>
        /// Gets the version of the Idfy .NET SDK.
        /// </summary>
        public static string SdkVersion
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                return assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            }
        }
        
        internal static string ClientId { get; set; }
        
        internal static string ClientSecret { get; set; }
        
        internal static IEnumerable<string> Scopes { get; set; }

        internal static OAuthToken OAuthToken { get; set; }
    }
}