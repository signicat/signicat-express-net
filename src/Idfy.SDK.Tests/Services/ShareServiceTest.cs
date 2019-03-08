using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using Idfy.Share;
using Idfy.Share.Entities;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{
    public class ShareServiceTest : BaseTest
    {
        private readonly ShareService _service;
        private string _jobId;
        private string _recipientId;

        public ShareServiceTest()
        {
            _service = new ShareService();
        }

        [SetUp]
        public void Setup()
        {
            _jobId = Guid.NewGuid().ToString();
            _recipientId = Guid.NewGuid().ToString();
        }
        
        [Test]
        public void GetShare()
        {
            var share = _service.GetShare(_jobId);

            Assert.IsNotNull(share);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}");
        }
        
        [Test]
        public async Task GetShareAsync()
        {
            var share = await _service.GetShareAsync(_jobId);

            Assert.IsNotNull(share);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}");
        }

        [Test]
        public void DeleteShareTest()
        {
            _service.DeleteShare(_jobId);
            
            AssertRequest(HttpMethod.Delete, $"/share/{_jobId}");
        }
        
        [Test]
        public async Task DeleteShareAsyncTest()
        {
            await _service.DeleteShareAsync(_jobId);
            
            AssertRequest(HttpMethod.Delete, $"/share/{_jobId}");
        }

        [Test]
        public void UpdateShare()
        {
            var options = Fixture.Create<ShareUpdateOptions>();

            var response = _service.UpdateShare(_jobId, options); 
            
            Assert.NotNull(response);
            AssertRequest(new HttpMethod("PATCH"), $"/share/{_jobId}");
        }
        
        [Test]
        public async Task UpdateShareAsync()
        {
            var options = Fixture.Create<ShareUpdateOptions>();

            var response = await _service.UpdateShareAsync(_jobId, options); 
            
            Assert.NotNull(response);
            AssertRequest(new HttpMethod("PATCH"), $"/share/{_jobId}");
        }
        
        [Test]
        public void GetRecipient()
        {
            var response = _service.GetShareRecipient(_jobId, _recipientId); 
            
            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}/recipients/{_recipientId}");

        }
        
        [Test]
        public async Task GetRecipientAsync()
        {
            var response = await _service.GetShareRecipientAsync(_jobId, _recipientId); 
            
            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void DeleteRecipient()
        {
            _service.DeleteShareRecipient(_jobId, _recipientId); 
            AssertRequest(HttpMethod.Delete, $"/share/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public async Task DeleteRecipientAsync()
        {
            await _service.DeleteShareRecipientAsync(_jobId, _recipientId); 
            AssertRequest(HttpMethod.Delete, $"/share/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void UpdateRecipient()
        {
            var options = Fixture.Create<RecipientUpdateOptions>();

            var result = _service.UpdateShareRecipient(_jobId, _recipientId, options); 
            Assert.NotNull(result);
            AssertRequest(new HttpMethod("PATCH"), $"/share/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public async Task UpdateRecipientAsync()
        {
            var options = Fixture.Create<RecipientUpdateOptions>();

            var result = await _service.UpdateShareRecipientAsync(_jobId, _recipientId, options); 
            Assert.NotNull(result);
            AssertRequest(new HttpMethod("PATCH"), $"/share/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void CreateRecipient()
        {
            var options = Fixture.Create<Recipient>();

            var result = _service.CreateShareRecipient(_jobId, options); 
            Assert.NotNull(result);
            AssertRequest(HttpMethod.Post, $"/share/{_jobId}/recipients");
        }
        
        [Test]
        public async Task CreateRecipientAsync()
        {
            var options = Fixture.Create<Recipient>();

            var result = await _service.CreateShareRecipientAsync(_jobId, options); 
            
            Assert.NotNull(result);
            AssertRequest(HttpMethod.Post, $"/share/{_jobId}/recipients");
        }

        [Test]
        public void UploadFileTest()
        {
            _service.UploadFile(_jobId, "1", new byte[10], "file.pdf");
            AssertRequest(HttpMethod.Post, $"/share/{_jobId}/upload/1");
        }
        
        [Test]
        public async Task UploadFileAsyncTest()
        {
            await _service.UploadFileAsync(_jobId, "1", new byte[10], "file.pdf");
            AssertRequest(HttpMethod.Post, $"/share/{_jobId}/upload/1");
        }
    }
}      