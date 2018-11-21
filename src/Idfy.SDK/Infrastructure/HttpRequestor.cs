using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Idfy.Infrastructure
{
    internal static class HttpRequestor
    {
        private static readonly HttpClient HttpClient;
        
        static HttpRequestor()
        {
            HttpClient = new HttpClient();

            if (IdfyConfiguration.HttpTimeout.HasValue)
                HttpClient.Timeout = IdfyConfiguration.HttpTimeout.Value;
        }

        public static IdfyResponse Get(string url, string token = null)
        {
            return Send(url, HttpMethod.Get, token);
        }

        public static Task<IdfyResponse> GetAsync(string url, string token = null)
        {
            return SendAsync(url, HttpMethod.Get, token);
        }
        
        public static IdfyResponse Post(string url, string jsonBody = null, string token = null)
        {
            return Send(url, HttpMethod.Post, token, jsonBody);
        }

        public static Task<IdfyResponse> PostAsync(string url, string jsonBody = null, string token = null)
        {
            return SendAsync(url, HttpMethod.Post, token, jsonBody);
        }
        
        public static IdfyResponse PostFormData(string url, NameValueCollection formData, string token = null)
        {
            return Send(url, HttpMethod.Post, token, formData: formData);
        }
        
        public static Task<IdfyResponse> PostFormDataAsync(string url, NameValueCollection formData, string token = null)
        {
            return SendAsync(url, HttpMethod.Post, token, formData: formData);
        }
        
        public static IdfyResponse Patch(string url, string jsonBody = null, string token = null)
        {
            return Send(url, new HttpMethod("PATCH"), token, jsonBody);
        }

        public static Task<IdfyResponse> PatchAsync(string url, string jsonBody = null, string token = null)
        {
            return SendAsync(url, new HttpMethod("PATCH"), token, jsonBody);
        }
        
        public static IdfyResponse Put(string url, string jsonBody = null, string token = null)
        {
            return Send(url, HttpMethod.Put, token, jsonBody);
        }

        public static Task<IdfyResponse> PutAsync(string url, string jsonBody = null, string token = null)
        {
            return SendAsync(url, HttpMethod.Put, token, jsonBody);
        }
        
        public static IdfyResponse Delete(string url, string token = null)
        {
            return Send(url, HttpMethod.Delete, token);
        }

        public static Task<IdfyResponse> DeleteAsync(string url, string token = null)
        {
            return SendAsync(url, HttpMethod.Delete, token);
        }
        
        public static Stream GetStream(string url, string token = null)
        {
            var request = GetRequestMessage(url, HttpMethod.Get, token);

            return ExecuteRawRequest(request);
        }
        
        public static Task<Stream> GetStreamAsync(string url, string token = null)
        {
            var request = GetRequestMessage(url, HttpMethod.Get, token);

            return ExecuteRawRequestAsync(request);
        }

        internal static HttpRequestMessage GetRequestMessage(string url, HttpMethod method, string token = null,
            string jsonBody = null, NameValueCollection formData = null)
        {
            var request = BuildRequest(url, method, jsonBody, formData);
            
            request.Headers.Add("X-Idfy-SDK", $".NET {IdfyConfiguration.SdkVersion}");
            
            if (!string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Add("Authorization", $"Bearer {token}");
            }

            return request;
        }

        private static IdfyResponse Send(string url, HttpMethod method, string token = null, string jsonBody = null,
            NameValueCollection formData = null)
        {
            var request = GetRequestMessage(url, method, token, jsonBody, formData);

            return ExecuteRequest(request);
        }

        private static Task<IdfyResponse> SendAsync(string url, HttpMethod method, string token = null,
            string jsonBody = null, NameValueCollection formData = null)
        {
            var request = GetRequestMessage(url, method, token, jsonBody, formData);

            return ExecuteRequestAsync(request);
        }

        private static HttpRequestMessage BuildRequest(string url, HttpMethod method, string jsonBody = null,
            NameValueCollection formData = null)
        {
            var request = new HttpRequestMessage(method, new Uri(url));

            if (method != HttpMethod.Post && method != HttpMethod.Put && method.Method != "PATCH") 
                return request;
            
            var postData = jsonBody;
            var contentType = "application/json";

            if (string.IsNullOrWhiteSpace(jsonBody) && formData != null)
            {
                postData = APIHelper.ToQueryString(formData).Substring(1);
                contentType = "application/x-www-form-urlencoded";
            }

            request.Content = !string.IsNullOrWhiteSpace(postData)
                ? new StringContent(postData, Encoding.UTF8, contentType)
                : null;

            return request;
        }
        
        private static IdfyResponse ExecuteRequest(HttpRequestMessage requestMessage)
        {
            return AsyncHelper.RunSync(() => ExecuteRequestAsync(requestMessage));
        }

        private static async Task<IdfyResponse> ExecuteRequestAsync(HttpRequestMessage requestMessage)
        {
            var response = await HttpClient.SendAsync(requestMessage);
            var content = await response.Content.ReadAsStringAsync();

            var result = BuildResponseData(response, content);

            if (response.IsSuccessStatusCode)
                return result;

            throw BuildException(result, response.StatusCode);
        }

        private static Stream ExecuteRawRequest(HttpRequestMessage requestMessage)
        {
            return AsyncHelper.RunSync(() => ExecuteRawRequestAsync(requestMessage));
        }
        
        private static async Task<Stream> ExecuteRawRequestAsync(HttpRequestMessage requestMessage)
        {
            var response = await HttpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStreamAsync();

            var errorContent = await response.Content.ReadAsStringAsync();
            var result = BuildResponseData(response, errorContent);
            
            throw BuildException(result, response.StatusCode);
        }
        
        private static IdfyResponse BuildResponseData(HttpResponseMessage response, string responseJson)
        {
            return new IdfyResponse()
            {
                RequestId = response.Headers.Contains("Request-Id")? response.Headers.GetValues("Request-Id").First(): null,
                RequestDate = Convert.ToDateTime(response.Headers.GetValues("Date").First(), CultureInfo.InvariantCulture),
                ResponseJson = responseJson
            };
        }
        
        private static IdfyException BuildException(IdfyResponse response, HttpStatusCode statusCode)
        {
            var idfyError = Mapper.MapFromJson<IdfyError>(response.ResponseJson);

            return new IdfyException(statusCode, idfyError, response, idfyError?.Message ?? idfyError?.Error);
        }
    }
}