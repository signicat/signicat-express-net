using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.MerchantSign
{
    /// <summary>
    /// Sign documents with a merchant signature.
    /// </summary>
    public class MerchantSignService : IdfyBaseService
    {
        public MerchantSignService()
        {   
        }

        public MerchantSignService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Creates a new merchant signature.
        /// </summary>
        /// <param name="signRequest"></param>
        /// <returns></returns>
        public SignResponse CreateMerchantSignature(SignRequest signRequest)
        {
            return Post<SignResponse>($"{Urls.MerchantSign}/signature");
        }
        
        /// <summary>
        /// Creates a new merchant signature.
        /// </summary>
        /// <param name="signRequest"></param>
        /// <returns></returns>
        public async Task<SignResponse> CreateMerchantSignatureAsync(SignRequest signRequest)
        {
            return await PostAsync<SignResponse>($"{Urls.MerchantSign}/signature");
        }

        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public MerchantSignTransaction GetTransation(Guid transactionId)
        {
            return Get<MerchantSignTransaction>($"{Urls.MerchantSign}/signature/{transactionId}");
        }
        
        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public async Task<MerchantSignTransaction> GetTransationAsync(Guid transactionId)
        {
            return await GetAsync<MerchantSignTransaction>($"{Urls.MerchantSign}/signature/{transactionId}");
        }

        /// <summary>
        /// Returns a list of transactions.
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public IList<MerchantSignTransaction> ListTransactions(
            string oauthClientId = null,
            long? fromDate = null,
            long? toDate = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.MerchantSign}/signature/list",
                new Dictionary<string, object>()
                {
                    {"oauthClientId", oauthClientId},
                    {"fromDate", fromDate},
                    {"toDate", toDate}
                });
            
            return Get<IList<MerchantSignTransaction>>(url);
        }
        
        /// <summary>
        /// Returns a list of transactions.
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public async Task<IList<MerchantSignTransaction>> ListTransactionsAsync(
            string oauthClientId = null,
            long? fromDate = null,
            long? toDate = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.MerchantSign}/signature/list",
                new Dictionary<string, object>()
                {
                    {"oauthClientId", oauthClientId},
                    {"fromDate", fromDate},
                    {"toDate", toDate}
                });
            
            return await GetAsync<IList<MerchantSignTransaction>>(url);
        }

        /// <summary>
        /// Retrieve PAdES of signed PDF file.
        /// </summary>
        /// <param name="signedDocumentId"></param>
        /// <returns></returns>
        public Stream GetPades(Guid signedDocumentId)
        {
            return GetFile($"{Urls.MerchantSign}/pades/{signedDocumentId}");
        }
        
        /// <summary>
        /// Retrieve PAdES of signed PDF file.
        /// </summary>
        /// <param name="signedDocumentId"></param>
        /// <returns></returns>
        public async Task<Stream> GetPadesAsync(Guid signedDocumentId)
        {
            return await GetFileAsync($"{Urls.MerchantSign}/pades/{signedDocumentId}");
        }
    }
}