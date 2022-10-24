using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Signicat.Express.Share
{
    public interface IShareService
    {
        /// <summary>
        /// Creates a new bucket
        /// </summary>
        /// <param name="bucketCreateOptions"></param>
        /// <returns>Id for the newly created bucket</returns>
        Task<BucketResponse> CreateSecureBucketAsync(BucketCreateOptions bucketCreateOptions);

        /// <summary>
        /// Creates a new bucket
        /// </summary>
        /// <param name="bucketCreateOptions"></param>
        /// <returns>Id for the newly created bucket</returns>
        BucketResponse CreateSecureBucket(BucketCreateOptions bucketCreateOptions);

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
        /// <param name="stream"></param>
        /// <param name="filename"></param>
        void UploadFile(string id, string fileId, Stream stream, string filename);

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
        /// Upload file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileId"></param>
        /// <param name="stream"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        Task UploadFileAsync(string id, string fileId, Stream stream, string filename);

        /// <summary>
        /// Retrieve bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BucketResponse GetBucket(string id);

        /// <summary>
        /// Retrieve bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<BucketResponse> GetBucketAsync(string id);

        /// <summary>
        /// Retrieve list of buckets
        /// </summary>
        /// <returns></returns>
        IEnumerable<BucketResponse> ListBuckets();

        /// <summary>
        /// Retrieve list of buckets
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<BucketResponse>> ListBucketsAsync();

        /// <summary>
        /// Delete bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteBucket(string id);

        /// <summary>
        /// Delete Bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteBucketAsync(string id);

        /// <summary>
        /// Update bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        BucketResponse UpdateBucket(string id, BucketUpdateOptions options);

        /// <summary>
        /// Update bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<BucketResponse> UpdateBucketAsync(string id, BucketUpdateOptions options);

        /// <summary>
        /// Retrieve bucket recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        RecipientResponse GetBucketRecipient(string id, string recipientId);

        /// <summary>
        /// Retrieve bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        Task<RecipientResponse> GetBucketRecipientAsync(string id, string recipientId);

        /// <summary>
        /// Delete bucket recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        void DeleteBucketRecipient(string id, string recipientId);

        /// <summary>
        /// Delete bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        Task DeleteBucketRecipientAsync(string id, string recipientId);


        /// <summary>
        /// Update bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        RecipientResponse UpdateBucketRecipient(string id, string recipientId, RecipientUpdateOptions recipient);

        /// <summary>
        /// Update bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        Task<RecipientResponse> UpdateBucketRecipientAsync(string id, string recipientId,
            RecipientUpdateOptions recipient);

        /// <summary>
        /// Create bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        RecipientResponse CreateBucketRecipient(string id, Recipient recipient);

        /// <summary>
        /// Create bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        Task<RecipientResponse> CreateBucketRecipientAsync(string id, Recipient recipient);

        /// <summary>
        /// List recipients on a bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<RecipientResponse> ListRecipients(string id);

        /// <summary>
        /// List recipients on a bucket async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<RecipientResponse>> ListRecipientsAsync(string id);
    }
}