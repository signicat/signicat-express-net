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

        public ShareService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Creates a new share async.
        /// </summary>
        /// <param name="shareCreateOptions"></param>
        /// <returns>Id for the newly created share</returns>
        public async Task<CreateShareResponse> CreateSecureShareAsync(ShareCreateOptions shareCreateOptions)
        {
            return await PostAsync<CreateShareResponse>($"{Urls.Share}", shareCreateOptions);
        }
        /// <summary>
        /// Creates a new share.
        /// </summary>
        /// <param name="shareCreateOptions"></param>
        /// <returns>Id for the newly created share</returns>
        public CreateShareResponse CreateSecureShare(ShareCreateOptions shareCreateOptions)
        {
            return Post<CreateShareResponse>($"{Urls.Share}", shareCreateOptions);
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
                PostFormContentData($"{Urls.Share}/{id}/upload/{fileId}", content);
            }
        }

        /// <summary>
        /// Upload file async
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
                await PostFormContentDataAsync($"{Urls.Share}/{id}/upload/{fileId}", content);
            }
        }
        /// <summary>
        /// Retrieve share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShareResponse GetShare(string id)
        {
            return Get<ShareResponse>($"{Urls.Share}/{id}");
        }
        /// <summary>
        /// Retrieve share async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ShareResponse> GetShareAsync(string id)
        {
            return await GetAsync<ShareResponse>($"{Urls.Share}/{id}");
        }
        /// <summary>
        /// Retrieve list of shares
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShareResponse> ListShares()
        {
            return Get<IEnumerable<ShareResponse>>($"{Urls.Share}/list");
        }

        /// <summary>
        /// Retrieve list of shares async
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShareResponse>> ListSharesAsync()
        {
            return await GetAsync<IEnumerable<ShareResponse>>($"{Urls.Share}/list");
        }
        /// <summary>
        /// Delete share
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteShare(string id)
        {
            Delete($"{Urls.Share}?id={id}");
        }

        /// <summary>
        /// Delete share async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteShareAsync(string id)
        {
            await DeleteAsync($"{Urls.Share}?id={id}");
        }

        /// <summary>
        /// Update share
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public ShareResponse UpdateShare(string id, ShareUpdateOptions options)
        {
            return Patch<ShareResponse>($"{Urls.Share}/{id}", options);
        }       
        /// <summary>
        /// Update share async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<ShareResponse> UpdateShareAsync(string id, ShareUpdateOptions options)
        {
            return await PatchAsync<ShareResponse>($"{Urls.Share}/{id}", options);
        }
        /// <summary>
        /// Retrieve share recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public RecipientResponse GetShareRecipient(string id, string recipientId)
        {
            return Get<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}");
        }
        /// <summary>
        /// Retrieve share recipient async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> GetShareRecipientAsync(string id, string recipientId)
        {
            return await GetAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}");
        }
        /// <summary>
        /// Delete share recipient 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public void DeleteShareRecipient(string id, string recipientId)
        {
            Delete($"{Urls.Share}/{id}/recipient/{recipientId}");
        }
        /// <summary>
        /// Delete share recipient async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        public async Task DeleteShareRecipientAsync(string id, string recipientId)
        {
            await DeleteAsync($"{Urls.Share}/{id}/recipient/{recipientId}");  
        }
        
        /// <summary>
        /// Update share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public RecipientResponse UpdateShareRecipient(string id, string recipientId, RecipientUpdateOptions options)
        {
            return Patch<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}", options);
        }
        /// <summary>
        /// Update share recipient async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> UpdateShareRecipientAsync(string id, string recipientId, RecipientUpdateOptions options)
        {
            return await PatchAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}", options);
        }
        /// <summary>
        /// Create share recipient
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public RecipientResponse CreateShareRecipient(string id, Recipient recipient)
        {
            return Post<RecipientResponse>($"{Urls.Share}/{id}/recipient", recipient);
        }

        /// <summary>
        /// Create share recipient async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recipient"></param>
        /// <returns></returns>
        public async Task<RecipientResponse> CreateShareRecipientAsync(string id, Recipient recipient)
        {
            return await PostAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient", recipient);
        }
    }
}