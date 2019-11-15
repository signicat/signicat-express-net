using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Idfy.Infrastructure;

namespace Idfy
{
    public static class IdfyConfiguration
    {
        private static string _baseUrl;
        private static string _oauthBaseUrl;

        public static void SetClientCredentials(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scopes = scopes.Select(s => s.ToEnumMemberString());
        }
        
        public static void SetClientCredentials(string clientId, string clientSecret, IEnumerable<string> scopes)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scopes = scopes;
        }
        
        /// <summary>
        /// Lets you provide your own HttpMessageHandler.
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; }
        
        public static TimeSpan? HttpTimeout { get; set; }
        
        public static string BaseUrl
        {
            get => string.IsNullOrWhiteSpace(_baseUrl) ? Urls.DefaultBaseUrl : _baseUrl;
            set => _baseUrl = value;
        }

        public static string OAuthBaseUrl
        {
            get => string.IsNullOrWhiteSpace(_oauthBaseUrl) ? Urls.DefaultOAuthBaseUrl : _oauthBaseUrl;
            set => _oauthBaseUrl = value;
        }

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