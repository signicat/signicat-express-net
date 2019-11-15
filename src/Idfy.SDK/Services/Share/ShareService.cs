using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Idfy.Infrastructure;
using Idfy.Share.Entities;

namespace Idfy.Share
{
    public class ShareService : IdfyBaseService, IShareService
    {
        public ShareService()
        {
        }

        public ShareService(string clientId, string clientSecret, IEnumerable<string> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }
        
        public ShareService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Creates a new bucket
        /// </summary>
        /// <param name="bucketCreateOptions"></param>
        /// <returns>Id for the newly created bucket</returns>
        public async Task<BucketResponse> CreateSecureBucketAsync(BucketCreateOptions bucketCreateOptions)
        {
            return await PostAsync<BucketResponse>($"{Urls.Share}/buckets", bucketCreateOptions);
        }
        
        /// <summary>
        /// Creates a new bucket
        /// </summary>
        /// <param name="bucketCreateOptions"></param>
        /// <returns>Id for the newly created bucket</returns>
        public BucketResponse CreateSecureBucket(BucketCreateOptions bucketCreateOptions)
        {
            return Post<BucketResponse>($"{Urls.Share}/buckets", bucketCreateOptions);
        }
        
        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void UploadFile(string id, string fileId, byte[] file, string filename)
        {
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StreamContent(new MemoryStream(file)), "file", filename);
                PostFormContentData($"{Urls.Share}/buckets/{id}/upload/{fileId}", content);
            }
        }

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public async Task UploadFileAsync(string id, string fileId, byte[] file, string filename)
        {
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StreamContent(new MemoryStream(file)), "file", filename);
                await PostFormContentDataAsync($"{Urls.Share}/buckets/{id}/upload/{fileId}", content);
            }
        }
        
        /// <summary>
        /// Retrieve bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BucketResponse GetBucket(string id)
        {
            return Get<BucketResponse>($"{Urls.Share}/buckets/{id}");
        }
        
        /// <summary>
        /// Retrieve bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<BucketResponse> GetBucketAsync(string id)
        {
            return await GetAsync<BucketResponse>($"{Urls.Share}/buckets/{id}");
        }
        
        /// <summary>
        /// Retrieve list of buckets
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BucketResponse> ListBuckets()
        {
            return Get<IEnumerable<BucketResponse>>($"{Urls.Share}/buckets");
        }

        /// <summary>
        /// Retrieve list of buckets
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BucketResponse>> ListBucketsAsync()
        {
            return await GetAsync<IEnumerable<BucketResponse>>($"{Urls.Share}/buckets");
        }
        
        /// <summary>
        /// Delete bucket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteBucket(string id)
        {
            Delete($"{Urls.Share}/buckets/{id}");
        }

        /// <summary>
        /// Delete bucket async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteBucketAsync(string id)
        {
            await DeleteAsync($"{Urls.Share}/buckets/{id}");
        }

        /// <summary>
        /// Update bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public BucketResponse UpdateBucket(string id, BucketUpdateOptions options)
        {
            return Patch<BucketResponse>($"{Urls.Share}/buckets/{id}", options);
        }
        
        /// <summary>
        /// Update bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<BucketResponse> UpdateBucketAsync(string id, BucketUpdateOptions options)
        {
            return await PatchAsync<BucketResponse>($"{Urls.Share}/buckets/{id}", options);
        }
        
        /// <summary>
        /// Retrieve bucket recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public RecipientResponse GetBucketRecipient(string id, string recipientId)
        {
            return Get<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients/{recipientId}");
        }
        
        /// <summary>
        /// Retrieve bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> GetBucketRecipientAsync(string id, string recipientId)
        {
            return await GetAsync<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients/{recipientId}");
        }
        
        /// <summary>
        /// Delete bucket recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public void DeleteBucketRecipient(string id, string recipientId)
        {
            Delete($"{Urls.Share}/buckets/{id}/recipients/{recipientId}");
        }
        /// <summary>
        /// Delete bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public async Task DeleteBucketRecipientAsync(string id, string recipientId)
        {
            await DeleteAsync($"{Urls.Share}/buckets/{id}/recipients/{recipientId}");  
        }

        /// <summary>
        /// Update bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public RecipientResponse UpdateBucketRecipient(string id, string recipientId, RecipientUpdateOptions options)
        {
            return Patch<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients/{recipientId}", options);
        }

        /// <summary>
        /// Update bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> UpdateBucketRecipientAsync(string id, string recipientId, RecipientUpdateOptions options)
        {
            return await PatchAsync<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients/{recipientId}", options);
        }
        
        /// <summary>
        /// Create bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public RecipientResponse CreateBucketRecipient(string id, Recipient recipient)
        {
            return Post<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients", recipient);
        }

        /// <summary>
        /// Create bucket recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> CreateBucketRecipientAsync(string id, Recipient recipient)
        {
            return await PostAsync<RecipientResponse>($"{Urls.Share}/buckets/{id}/recipients", recipient);
        }

        /// <summary>
        /// List recipients
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<RecipientResponse> ListRecipients(string id)
        {
            return Get<IEnumerable<RecipientResponse>>($"{Urls.Share}/buckets/{id}/recipients");
        }

        /// <summary>
        /// List recipients async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<RecipientResponse>> ListRecipientsAsync(string id)
        {
            return await GetAsync<IEnumerable<RecipientResponse>>($"{Urls.Share}/buckets/{id}/recipients");
        }
    }
}