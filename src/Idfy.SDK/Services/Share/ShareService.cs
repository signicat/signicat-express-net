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
            IdfyConfiguration.BaseUrl = "https://api.idfy.no";
        }

        public async Task<CreateShareResponse> CreateSecureShareAsync(ShareCreateOptions shareCreateOptions)
        {
            return await PostAsync<CreateShareResponse>($"{Urls.Share}", shareCreateOptions);
        }

        public CreateShareResponse CreateSecureShare(ShareCreateOptions shareCreateOptions)
        {
            return Post<CreateShareResponse>($"{Urls.Share}", shareCreateOptions);
        }

        public void UploadFile(string id, string fileId, byte[] file, string filename)
        {
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StreamContent(new MemoryStream(file)), "file", filename);
                PostFormContentData($"{Urls.Share}/{id}/upload/{fileId}", content);
            }
        }

        public async Task UploadFileAsync(string id, string fileId, byte[] file, string filename)
        {
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StreamContent(new MemoryStream(file)), "file", filename);
                await PostFormContentDataAsync($"{Urls.Share}/{id}/upload/{fileId}", content);
            }
        }

        public ShareResponse GetShare(string id)
        {
            return Get<ShareResponse>($"{Urls.Share}/{id}");
        }

        public async Task<ShareResponse> GetShareAsync(string id)
        {
            return await GetAsync<ShareResponse>($"{Urls.Share}/{id}");
        }

        public IEnumerable<ShareResponse> ListShares()
        {
            return Get<IEnumerable<ShareResponse>>($"{Urls.Share}/list");
        }

        public async Task<IEnumerable<ShareResponse>> ListSharesAsync()
        {
            return await GetAsync<IEnumerable<ShareResponse>>($"{Urls.Share}/list");
        }

        public void DeleteShare(string id)
        {
            Delete($"{Urls.Share}?id={id}");
        }

        public async Task DeleteShareAsync(string id)
        {
            await DeleteAsync($"{Urls.Share}?id={id}");
        }

        public ShareResponse UpdateShare(string id, ShareUpdateOptions options)
        {
            return Patch<ShareResponse>($"{Urls.Share}/{id}", options);
        }

        public async Task<ShareResponse> UpdateShareAsync(string id, ShareUpdateOptions options)
        {
            return await PatchAsync<ShareResponse>($"{Urls.Share}/{id}", options);
        }

        public RecipientResponse GetShareRecipient(string id, string recipientId)
        {
            return Get<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}");
        }

        public async Task<RecipientResponse> GetShareRecipientAsync(string id, string recipientId)
        {
            return await GetAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}");
        }

        public void DeleteShareRecipient(string id, string recipientId)
        {
            Delete($"{Urls.Share}/{id}/recipient/{recipientId}");
        }

        public async Task DeleteShareRecipientAsync(string id, string recipientId)
        {
            await DeleteAsync($"{Urls.Share}/{id}/recipient/{recipientId}");  
        }

        public RecipientResponse UpdateShareRecipient(string id, string recipientId, RecipientUpdateOptions options)
        {
            return Patch<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}", options);
        }

        public async Task<RecipientResponse> UpdateShareRecipientAsync(string id, string recipientId, RecipientUpdateOptions options)
        {
            return await PatchAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient/{recipientId}", options);
        }

        public RecipientResponse CreateShareRecipient(string id, Recipient recipient)
        {
            return Post<RecipientResponse>($"{Urls.Share}/{id}/recipient", recipient);
        }

        public async Task<RecipientResponse> CreateShareRecipientAsync(string id, Recipient recipient)
        {
            return await PostAsync<RecipientResponse>($"{Urls.Share}/{id}/recipient", recipient);
        }
    }
}