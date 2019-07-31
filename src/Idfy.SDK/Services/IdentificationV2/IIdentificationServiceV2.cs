using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idfy.IdentificationV2
{
    public interface IIdentificationServiceV2
    {
        /// <summary>
        /// Retrieves the details of a single identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IdSession GetSession(string id);

        /// <summary>
        /// Retrieves the details of a single identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IdSession> GetSessionAsync(string id);

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        IEnumerable<IdSession> ListSessions(string cursor = null, int? limit = null);

        /// <summary>
        /// Returns a list of previously created sessions. The session data returned from this endpoint does not contain any personal information.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        Task<IEnumerable<IdSession>> ListSessionsAsync(string cursor = null, int? limit = null);
        
        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        IdSession CreateSession(IdSessionCreate idSessionCreateOptions);

        /// <summary>
        /// Creates a new identification session.
        /// </summary>
        /// <param name="idSessionCreateOptions"></param>
        /// <returns></returns>
        Task<IdSession> CreateSessionAsync(IdSessionCreate idSessionCreateOptions);

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        void InvalidateSession(string id);

        /// <summary>
        /// Invalidates the specified identification session.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task InvalidateSessionAsync(string id);

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        IEnumerable<LanguageDetails> ListLanguages();

        /// <summary>
        /// Returns a list of supported languages.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<LanguageDetails>> ListLanguagesAsync();

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        IEnumerable<AppIdProvider> ListProviders();

        /// <summary>
        /// Returns a list of all the supported ID providers.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AppIdProvider>> ListProvidersAsync();
    }
}