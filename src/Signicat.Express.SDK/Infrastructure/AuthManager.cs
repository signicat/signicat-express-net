using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Idfy.Infrastructure
{
    internal static class AuthManager {
        public static OAuthToken Authorize()
        {
            IdfyConfiguration.OAuthToken = Authorize(IdfyConfiguration.ClientId, IdfyConfiguration.ClientSecret, IdfyConfiguration.Scopes);
            return IdfyConfiguration.OAuthToken;
        }
        
        public static OAuthToken Authorize(string clientId, string clientSecret, IEnumerable<string> scopes)
        {
            if (clientId == null)
                throw new InvalidOperationException("Client credentials not set.");

            var formData = new NameValueCollection()
            {
                {"grant_type", "client_credentials"},
                {"scope", string.Join(" ", scopes)},
                {"client_id", clientId},
                {"client_secret", clientSecret}
            };

            var token = Mapper.MapFromJson<OAuthToken>(HttpRequestor.PostFormData(Urls.OAuthToken, formData));
            token.Expiry = DateTime.UtcNow.AddSeconds(token.ExpiresIn);
            return token;
        }
    }
}