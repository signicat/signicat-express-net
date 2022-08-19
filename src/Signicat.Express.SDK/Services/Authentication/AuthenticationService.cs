using System.Collections.Generic;
using System.Threading.Tasks;
using Signicat.Express.Infrastructure;

namespace Signicat.Express.Authentication
{
    public class AuthenticationService : SignicatBaseService, IAuthenticationService
    {
        public AuthenticationService()
        {
        }
        
        public AuthenticationService(string clientId, string clientSecret, IEnumerable<string> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        public AuthenticationService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }
        
        /// <summary>
        /// Retrieves the details of a single identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IdSession GetSession(string id)
        {
            return Get<IdSession>($"{Urls.Authentication}/sessions/{id}");
        }

        /// <summary>
        /// Retrieves the details of a single identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<IdSession> GetSessionAsync(string id)
        {
            return GetAsync<IdSession>($"{Urls.Authentication}/sessions/{id}");
        }

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public PaginatedData<IdSession> ListSessions(string cursor = null, int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Authentication}/sessions", new Dictionary<string, object>()
            {
                {"cursor", cursor},
                {"limit", limit}
            });

            return Get<PaginatedData<IdSession>>(url);
        }

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public Task<PaginatedData<IdSession>> ListSessionsAsync(string cursor = null, int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Authentication}/sessions", new Dictionary<string, object>()
            {
                {"cursor", cursor},
                {"limit", limit}
            });

            return GetAsync<PaginatedData<IdSession>>(url);
        }

        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        public IdSession CreateSession(IdSessionCreateOptions idSessionCreateOptions)
        {
            return Post<IdSession>($"{Urls.Authentication}/sessions", idSessionCreateOptions);
        }

        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        public Task<IdSession> CreateSessionAsync(IdSessionCreateOptions idSessionCreateOptions)
        {
            return PostAsync<IdSession>($"{Urls.Authentication}/sessions", idSessionCreateOptions);
        }

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void InvalidateSession(string id)
        {
            Post($"{Urls.Authentication}/sessions/{id}/invalidate");
        }

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task InvalidateSessionAsync(string id)
        {
            await PostAsync($"{Urls.Authentication}/sessions/{id}/invalidate");
        }

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LanguageDetails> ListLanguages()
        {
            return Get<IEnumerable<LanguageDetails>>($"{Urls.Authentication}/languages");
        }

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<LanguageDetails>> ListLanguagesAsync()
        {
            return GetAsync<IEnumerable<LanguageDetails>>($"{Urls.Authentication}/languages");
        }

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AppIdProvider> ListIdProviders()
        {
            return Get<IEnumerable<AppIdProvider>>($"{Urls.Authentication}/id-providers");
        }

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<AppIdProvider>> ListIdProvidersAsync()
        {
            return GetAsync<IEnumerable<AppIdProvider>>($"{Urls.Authentication}/id-providers");
        }
        
        /// <summary>
        /// Returns a list of all the ID providers available for the requester's account.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AppIdProvider> ListIdProvidersForAccount()
        {
            return Get<IEnumerable<AppIdProvider>>($"{Urls.Authentication}/id-providers/account");
        }

        /// <summary>
        /// Returns a list of all the ID providers available for the requester's account.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<AppIdProvider>> ListIdProvidersForAccountAsync()
        {
            return GetAsync<IEnumerable<AppIdProvider>>($"{Urls.Authentication}/id-providers/account");
        }
    }
}