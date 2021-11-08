using System;
using System.Linq;
using System.Net.Http;
using NUnit.Framework;
using Signicat.Express.Infrastructure;

namespace Signicat.Express.SDK.Tests
{
    [TestFixture]
    public class HttpRequestorTest : BaseTest
    {
        [Test]
        public void BuildsRequestMessage()
        {
            var url = $"{Urls.SignatureDocuments}/{Guid.NewGuid()}";
            var token = "access-token";
            
            var request = HttpRequestor.GetRequestMessage(url, HttpMethod.Get, token);
            
            Assert.IsNotNull(request);
            
            Assert.AreEqual(new Uri(url), request.RequestUri);

            Assert.AreEqual($"Bearer {token}", request.Headers.GetValues("Authorization").FirstOrDefault());

            Assert.AreEqual($".NET {IdfyConfiguration.SdkVersion}",
                request.Headers.GetValues("X-Idfy-SDK").FirstOrDefault());
            
            Assert.AreEqual(HttpMethod.Get, request.Method);
        }
    }
}