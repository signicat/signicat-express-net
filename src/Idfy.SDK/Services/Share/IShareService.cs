using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Share.Entities;
using Idfy.Signature;

namespace Idfy.Share
{
    public interface IShareService
    {
        /// <summary>
        /// Creates a new share
        /// </summary>
        /// <param name="shareCreateOptions"></param>
        /// <returns>Id for the newly created share</returns>
        Task<CreateShareResponse> CreateSecureShareAsync(ShareCreateOptions shareCreateOptions);

        /// <summary>
        /// Creates a new share
        /// </summary>
        /// <param name="shareCreateOptions"></param>
        /// <returns>Id for the newly created share</returns>
        CreateShareResponse CreateSecureShare(ShareCreateOptions shareCreateOptions);

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        void UploadFile(string id, string fileId, byte[] file, string filename);

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        Task UploadFileAsync(string id, string fileId, byte[] file, string filename);

        /// <summary>
        /// Retrieve share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ShareResponse GetShare(string id);

        /// <summary>
        /// Retrieve share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ShareResponse> GetShareAsync(string id);

        /// <summary>
        /// Retrieve list of shares
        /// </summary>
        /// <returns></returns>
        IEnumerable<ShareResponse> ListShares();

        /// <summary>
        /// Retrieve list of shares
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ShareResponse>> ListSharesAsync();

        /// <summary>
        /// Delete share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteShare(string id);

        /// <summary>
        /// Delete share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteShareAsync(string id);

        /// <summary>
        /// Update share
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        ShareResponse UpdateShare(string id, ShareUpdateOptions options);

        /// <summary>
        /// Update share
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<ShareResponse> UpdateShareAsync(string id, ShareUpdateOptions options);

        /// <summary>
        /// Retrieve share recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        RecipientResponse GetShareRecipient(string id, string recipientId);

        /// <summary>
        /// Retrieve share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        Task<RecipientResponse> GetShareRecipientAsync(string id, string recipientId);

        /// <summary>
        /// Delete share recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        void DeleteShareRecipient(string id, string recipientId);

        /// <summary>
        /// Delete share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        Task DeleteShareRecipientAsync(string id, string recipientId);


        /// <summary>
        /// Update share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        RecipientResponse UpdateShareRecipient(string id, string recipientId, RecipientUpdateOptions recipient);

        /// <summary>
        /// Update share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        Task<RecipientResponse> UpdateShareRecipientAsync(string id, string recipientId, RecipientUpdateOptions recipient);
                
        /// <summary>
        /// Create share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        RecipientResponse CreateShareRecipient(string id, Recipient recipient);

        /// <summary>
        /// Create share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        Task<RecipientResponse> CreateShareRecipientAsync(string id, Recipient recipient);
    }
}