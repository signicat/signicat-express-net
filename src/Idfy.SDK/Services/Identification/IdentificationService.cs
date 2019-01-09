using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.Identification
{
    /// <summary>
    /// Identify users through eID providers such as Norwegian BankID, Swedish BankID and NemID.
    /// </summary>
    public class IdentificationService : IdfyBaseService, IIdentificationService
    {
        public IdentificationService()
        {
        }

        public IdentificationService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieves the response of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="metaData"></param>
        /// <returns></returns>
        public IdentificationResponse GetSession(string requestId, bool? metaData = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session", new Dictionary<string, object>()
            {
                {"requestId", requestId},
                {"metaData", metaData}
            });

            return Get<IdentificationResponse>(url);
        }

        /// <summary>
        /// Retrieves the response of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="metaData"></param>
        /// <returns></returns>
        public async Task<IdentificationResponse> GetSessionAsync(string requestId, bool? metaData = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session", new Dictionary<string, object>()
            {
                {"requestId", requestId},
                {"metaData", metaData}
            });

            return await GetAsync<IdentificationResponse>(url);
        }

        /// <summary>
        /// Creates a new identification session
        /// </summary>
        /// <param name="createIdentificationRequest"></param>
        /// <returns></returns>
        public CreateIdentificationResponse CreateSession(CreateIdentificationRequest createIdentificationRequest)
        {
            return Post<CreateIdentificationResponse>($"{Urls.Identification}/session", createIdentificationRequest);
        }

        /// <summary>
        /// Creates a new identification session
        /// </summary>
        /// <param name="createIdentificationRequest"></param>
        /// <returns></returns>
        public async Task<CreateIdentificationResponse> CreateSessionAsync(
            CreateIdentificationRequest createIdentificationRequest)
        {
            return await PostAsync<CreateIdentificationResponse>($"{Urls.Identification}/session",
                createIdentificationRequest);
        }

        /// <summary>
        /// Retrieves the status of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public IdentificationCompleteResponse GetSessionStatus(string requestId)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session/status",
                new Dictionary<string, object>()
                {
                    {"requestId", requestId}
                });

            return Get<IdentificationCompleteResponse>(url);
        }

        /// <summary>
        /// Retrieves the status of a single identification session.
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public async Task<IdentificationCompleteResponse> GetSessionStatusAsync(string requestId)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session/status",
                new Dictionary<string, object>()
                {
                    {"requestId", requestId}
                });

            return await GetAsync<IdentificationCompleteResponse>(url);
        }

        /// <summary>
        /// Invalidates an identification session to avoid using the same request twice.
        /// </summary>
        /// <param name="requestId"></param>
        public void InvalidateSession(string requestId)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session/invalidate",
                new Dictionary<string, object>()
                {
                    {"requestId", requestId}
                });

            Put(url);
        }

        /// <summary>
        /// Invalidates an identification session to avoid using the same request twice.
        /// </summary>
        /// <param name="requestId"></param>
        public async Task InvalidateSessionAsync(string requestId)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/session/invalidate",
                new Dictionary<string, object>()
                {
                    {"requestId", requestId}
                });

            await PutAsync(url);
        }

        /// <summary>
        /// Gets an historic identification session (older than 14 days).
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public IdentificationLogItem GetLogEntry(string requestId)
        {
            return Get<IdentificationLogItem>($"{Urls.Identification}/log/requestId/{requestId}");
        }

        /// <summary>
        /// Gets an historic identification session (older than 14 days).
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public async Task<IdentificationLogItem> GetLogEntryAsync(string requestId)
        {
            return await GetAsync<IdentificationLogItem>($"{Urls.Identification}/log/requestId/{requestId}");
        }

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
        public LogItemList ListLogEntries(
            int year,
            int? month = null,
            int? day = null,
            string status = null,
            string identityProviderType = null,
            string externalId = null,
            string name = null,
            int? skip = null,
            int? pageSize = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/log/filter/{year}",
                new Dictionary<string, object>()
                {
                    {"month", month},
                    {"day", day},
                    {"status", status},
                    {"identityProviderType", identityProviderType},
                    {"externalId", externalId},
                    {"name", name},
                    {"skip", skip},
                    {"pageSize", pageSize}
                });

            return Get<LogItemList>(url);
        }

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
        public async Task<LogItemList> ListLogEntriesAsync(
            int year,
            int? month = null,
            int? day = null,
            string status = null,
            string identityProviderType = null,
            string externalId = null,
            string name = null,
            int? skip = null,
            int? pageSize = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Identification}/log/filter/{year}",
                new Dictionary<string, object>()
                {
                    {"month", month},
                    {"day", day},
                    {"status", status},
                    {"identityProviderType", identityProviderType},
                    {"externalId", externalId},
                    {"name", name},
                    {"skip", skip},
                    {"pageSize", pageSize}
                });

            return await GetAsync<LogItemList>(url);
        }

        /// <summary>
        /// Creates a new Norwegian BankID mobile session to start the identification process.
        /// </summary>
        /// <param name="createBankIdMobileRequest"></param>
        /// <returns></returns>
        public CreateBankIDMobileResponse CreateBankIdMobileSession(CreateBankIDMobileRequest createBankIdMobileRequest)
        {
            return Post<CreateBankIDMobileResponse>($"{Urls.Identification}/no/bankid/mobile",
                createBankIdMobileRequest);
        }

        /// <summary>
        /// Creates a new Norwegian BankID mobile session to start the identification process.
        /// </summary>
        /// <param name="createBankIdMobileRequest"></param>
        /// <returns></returns>
        public async Task<CreateBankIDMobileResponse> CreateBankIdMobileSessionAsync(
            CreateBankIDMobileRequest createBankIdMobileRequest)
        {
            return await PostAsync<CreateBankIDMobileResponse>($"{Urls.Identification}/no/bankid/mobile",
                createBankIdMobileRequest);
        }
    }
}