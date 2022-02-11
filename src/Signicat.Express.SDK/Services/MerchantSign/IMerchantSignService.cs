using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Signicat.Express.MerchantSign
{
    public interface IMerchantSignService
    {
        /// <summary>
        /// Creates a new merchant signature.
        /// </summary>
        /// <param name="signRequest"></param>
        /// <returns></returns>
        SignResponse CreateMerchantSignature(SignRequest signRequest);

        /// <summary>
        /// Creates a new merchant signature.
        /// </summary>
        /// <param name="signRequest"></param>
        /// <returns></returns>
        Task<SignResponse> CreateMerchantSignatureAsync(SignRequest signRequest);

        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        [Obsolete("This method is obsolete. Please use GetTransaction instead.")]
        MerchantSignTransaction GetTransation(Guid transactionId);

        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        [Obsolete("This method is obsolete. Please use GetTransactionAsync instead.")]
        Task<MerchantSignTransaction> GetTransationAsync(Guid transactionId);

        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        MerchantSignTransaction GetTransaction(Guid transactionId);

        /// <summary>
        /// Retrieves a single transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        Task<MerchantSignTransaction> GetTransactionAsync(Guid transactionId);

        /// <summary>
        /// Returns a list of transactions.
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        IList<MerchantSignTransaction> ListTransactions(
            string oauthClientId = null,
            long? fromDate = null,
            long? toDate = null);

        /// <summary>
        /// Returns a list of transactions.
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        Task<IList<MerchantSignTransaction>> ListTransactionsAsync(
            string oauthClientId = null,
            long? fromDate = null,
            long? toDate = null);

        /// <summary>
        /// Retrieve PAdES of signed PDF file.
        /// </summary>
        /// <param name="signedDocumentId"></param>
        /// <returns></returns>
        Stream GetPades(Guid signedDocumentId);

        /// <summary>
        /// Retrieve PAdES of signed PDF file.
        /// </summary>
        /// <param name="signedDocumentId"></param>
        /// <returns></returns>
        Task<Stream> GetPadesAsync(Guid signedDocumentId);
    }
}