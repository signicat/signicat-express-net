using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy
{
    public abstract class IdfyBaseService
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly IEnumerable<OAuthScope> _scopes;
        private OAuthToken _oAuthToken;

        protected IdfyBaseService() { }

        protected IdfyBaseService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
        {
            _clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
            _clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));
            _scopes = scopes ?? throw new ArgumentNullException(nameof(scopes));
        }

        protected T Get<T>(string url)
        {
            return Mapper.MapFromJson<T>(HttpRequestor.Get(url, GetToken()));
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            return Mapper.MapFromJson<T>(await HttpRequestor.GetAsync(url, GetToken()));
        }

        protected Stream GetFile(string url)
        {
            return HttpRequestor.GetStream(url);
        }

        protected async Task<Stream> GetFileAsync(string url)
        {
            return await HttpRequestor.GetStreamAsync(url);
        }

        protected T Post<T>(string url, object requestObject = null)
        {
            return Mapper.MapFromJson<T>(
                HttpRequestor.Post(url, Mapper.MapToJson(requestObject), GetToken()));
        }

        protected async Task<T> PostAsync<T>(string url, object requestObject = null)
        {
            return Mapper.MapFromJson<T>(
                await HttpRequestor.PostAsync(url, Mapper.MapToJson(requestObject), GetToken()));
        }
        
        protected void Post(string url, object requestObject = null)
        {
            HttpRequestor.Post(url, token: GetToken());
        }

        protected async Task PostAsync(string url, object requestObject = null)
        {
            await HttpRequestor.PostAsync(url, token: GetToken());
        }

        protected T Patch<T>(string url, object requestObject = null)
        {
            return Mapper.MapFromJson<T>(
                HttpRequestor.Patch(url, Mapper.MapToJson(requestObject), GetToken()));
        }

        protected async Task<T> PatchAsync<T>(string url, object requestObject = null)
        {
            return Mapper.MapFromJson<T>(
                await HttpRequestor.PatchAsync(url, Mapper.MapToJson(requestObject), GetToken()));
        }
        
        protected void Put(string url, object requestObject = null)
        {
            HttpRequestor.Put(url, Mapper.MapToJson(requestObject), GetToken());
        }

        protected async Task PutAsync(string url, object requestObject = null)
        {
            await HttpRequestor.PutAsync(url, Mapper.MapToJson(requestObject), GetToken());
        }

        protected void Delete(string url)
        {
            HttpRequestor.Delete(url, GetToken());
        }

        protected async Task DeleteAsync(string url)
        {
            await HttpRequestor.DeleteAsync(url, GetToken());
        }

        private string GetToken()
        {
            if (_oAuthToken?.Expiry > DateTime.UtcNow)
                return _oAuthToken.AccessToken;

            _oAuthToken = _clientId == null
                ? AuthManager.Authorize()
                : AuthManager.Authorize(_clientId, _clientSecret, _scopes);

            return _oAuthToken.AccessToken;
        }
    }
}