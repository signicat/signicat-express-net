using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.IdentificationV2
{
    public class IdentificationServiceV2 : IdfyBaseService, IIdentificationServiceV2
    {
        public IdentificationServiceV2()
        {
        }

        public IdentificationServiceV2(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
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
            return Get<IdSession>($"{Urls.IdentificationV2}/sessions/{id}");
        }

        /// <summary>
        /// Retrieves the details of a single identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<IdSession> GetSessionAsync(string id)
        {
            return GetAsync<IdSession>($"{Urls.IdentificationV2}/sessions/{id}");
        }

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public IEnumerable<IdSession> ListSessions(string cursor = null, int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.IdentificationV2}/sessions", new Dictionary<string, object>()
            {
                {"cursor", cursor},
                {"limit", limit}
            });

            return Get<IEnumerable<IdSession>>(url);
        }

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public Task<IEnumerable<IdSession>> ListSessionsAsync(string cursor = null, int? limit = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.IdentificationV2}/sessions", new Dictionary<string, object>()
            {
                {"cursor", cursor},
                {"limit", limit}
            });

            return GetAsync<IEnumerable<IdSession>>(url);
        }

        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        public IdSession CreateSession(IdSessionCreate idSessionCreateOptions)
        {
            return Post<IdSession>($"{Urls.IdentificationV2}/sessions", idSessionCreateOptions);
        }

        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        public Task<IdSession> CreateSessionAsync(IdSessionCreate idSessionCreateOptions)
        {
            return PostAsync<IdSession>($"{Urls.IdentificationV2}/sessions", idSessionCreateOptions);
        }

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void InvalidateSession(string id)
        {
            Post($"{Urls.IdentificationV2}/sessions/{id}/invalidate");
        }

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task InvalidateSessionAsync(string id)
        {
            await PostAsync($"{Urls.IdentificationV2}/sessions/{id}/invalidate");
        }

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LanguageDetails> ListLanguages()
        {
            return Get<IEnumerable<LanguageDetails>>($"{Urls.IdentificationV2}/languages");
        }

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<LanguageDetails>> ListLanguagesAsync()
        {
            return GetAsync<IEnumerable<LanguageDetails>>($"{Urls.IdentificationV2}/languages");
        }

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AppIdProvider> ListProviders()
        {
            return Get<IEnumerable<AppIdProvider>>($"{Urls.IdentificationV2}/id-providers");
        }

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<AppIdProvider>> ListProvidersAsync()
        {
            return GetAsync<IEnumerable<AppIdProvider>>($"{Urls.IdentificationV2}/id-providers");
        }
    }
}