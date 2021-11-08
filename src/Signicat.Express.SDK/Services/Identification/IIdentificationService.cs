using System.Threading.Tasks;

namespace Signicat.Express.Identification
{
    public interface IIdentificationService
    {
        /// <summary>
        /// Retrieves the response of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="metaData"></param>
        /// <returns></returns>
        IdentificationResponse GetSession(string requestId, bool? metaData = null);

        /// <summary>
        /// Retrieves the response of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="metaData"></param>
        /// <returns></returns>
        Task<IdentificationResponse> GetSessionAsync(string requestId, bool? metaData = null);

        /// <summary>
        /// Creates a new identification session
        /// </summary>
        /// <param name="createIdentificationRequest"></param>
        /// <returns></returns>
        CreateIdentificationResponse CreateSession(CreateIdentificationRequest createIdentificationRequest);

        /// <summary>
        /// Creates a new identification session
        /// </summary>
        /// <param name="createIdentificationRequest"></param>
        /// <returns></returns>
        Task<CreateIdentificationResponse> CreateSessionAsync(
            CreateIdentificationRequest createIdentificationRequest);

        /// <summary>
        /// Retrieves the status of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        IdentificationCompleteResponse GetSessionStatus(string requestId);

        /// <summary>
        /// Retrieves the status of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        Task<IdentificationCompleteResponse> GetSessionStatusAsync(string requestId);

        /// <summary>
        /// Invalidates an identification session to avoid using the same request twice.
        /// </summary>
        /// <param name="requestId"></param>
        void InvalidateSession(string requestId);

        /// <summary>
        /// Invalidates an identification session to avoid using the same request twice.
        /// </summary>
        /// <param name="requestId"></param>
        Task InvalidateSessionAsync(string requestId);

        /// <summary>
        /// Gets an historic identification session (older than 14 days).
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        IdentificationLogItem GetLogEntry(string requestId);

        /// <summary>
        /// Gets an historic identification session (older than 14 days).
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        Task<IdentificationLogItem> GetLogEntryAsync(string requestId);

        /// <summary>
        /// Lists historic identification sessions filtered by the provided parameters.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="status"></param>
        /// <param name="identityProviderType"></param>
        /// <param name="externalId"></param>
        /// <param name="name"></param>
        /// <param name="skip"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        LogItemList ListLogEntries(
            int year,
            int? month = null,
            int? day = null,
            string status = null,
            string identityProviderType = null,
            string externalId = null,
            string name = null,
            int? skip = null,
            int? pageSize = null);

        /// <summary>
        /// Lists historic identification sessions filtered by the provided parameters.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="status"></param>
        /// <param name="identityProviderType"></param>
        /// <param name="externalId"></param>
        /// <param name="name"></param>
        /// <param name="skip"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<LogItemList> ListLogEntriesAsync(
            int year,
            int? month = null,
            int? day = null,
            string status = null,
            string identityProviderType = null,
            string externalId = null,
            string name = null,
            int? skip = null,
            int? pageSize = null);

        /// <summary>
        /// Creates a new Norwegian BankID mobile session to start the identification process.
        /// </summary>
        /// <param name="createBankIdMobileRequest"></param>
        /// <returns></returns>
        CreateBankIDMobileResponse CreateBankIdMobileSession(CreateBankIDMobileRequest createBankIdMobileRequest);

        /// <summary>
        /// Creates a new Norwegian BankID mobile session to start the identification process.
        /// </summary>
        /// <param name="createBankIdMobileRequest"></param>
        /// <returns></returns>
        Task<CreateBankIDMobileResponse> CreateBankIdMobileSessionAsync(
            CreateBankIDMobileRequest createBankIdMobileRequest);
    }
}