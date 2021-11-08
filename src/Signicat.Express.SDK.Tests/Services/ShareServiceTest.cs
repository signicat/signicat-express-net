using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using Idfy.Share;
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
            var share = _service.GetBucket(_jobId);

            Assert.IsNotNull(share);
            AssertRequest(HttpMethod.Get, $"/share/buckets/{_jobId}");
        }
        
        [Test]
        public async Task GetShareAsync()
        {
            var share = await _service.GetBucketAsync(_jobId);

            Assert.IsNotNull(share);
            AssertRequest(HttpMethod.Get, $"/share/buckets/{_jobId}");
        }
        
        

        [Test]
        public void DeleteShare()
        {
            _service.DeleteBucket(_jobId);
            
            AssertRequest(HttpMethod.Delete, $"/share/buckets/{_jobId}");
        }
        
        [Test]
        public async Task DeleteShareAsync()
        {
            await _service.DeleteBucketAsync(_jobId);
            
            AssertRequest(HttpMethod.Delete, $"/share/buckets/{_jobId}");
        }

        [Test]
        public void UpdateShare()
        {
            var options = Fixture.Create<BucketUpdateOptions>();

            var response = _service.UpdateBucket(_jobId, options); 
            
            Assert.NotNull(response);
            AssertRequest(new HttpMethod("PATCH"), $"/share/buckets/{_jobId}");
        }
        
        [Test]
        public async Task UpdateShareAsync()
        {
            var options = Fixture.Create<BucketUpdateOptions>();

            var response = await _service.UpdateBucketAsync(_jobId, options); 
            
            Assert.NotNull(response);
            AssertRequest(new HttpMethod("PATCH"), $"/share/buckets/{_jobId}");
        }

        [Test]
        [Ignore("Not yet available in production.")]
        public void ListShares()
        {
            var response = _service.ListBuckets();

            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, "/share");
        }

        [Test]
        [Ignore("Not yet available in production.")]
        public async Task ListSharesAsync()
        {
            var response = await _service.ListBucketsAsync();
            
            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, "/share");
        }


        
        [Test]
        public void GetRecipient()
        {
            var response = _service.GetBucketRecipient(_jobId, _recipientId); 
            
            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, $"/share/buckets/{_jobId}/recipients/{_recipientId}");

        }
        
        [Test]
        public async Task GetRecipientAsync()
        {
            var response = await _service.GetBucketRecipientAsync(_jobId, _recipientId); 
            
            Assert.NotNull(response);
            AssertRequest(HttpMethod.Get, $"/share/buckets/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void DeleteRecipient()
        {
            _service.DeleteBucketRecipient(_jobId, _recipientId); 
            AssertRequest(HttpMethod.Delete, $"/share/buckets/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public async Task DeleteRecipientAsync()
        {
            await _service.DeleteBucketRecipientAsync(_jobId, _recipientId); 
            AssertRequest(HttpMethod.Delete, $"/share/buckets/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void UpdateRecipient()
        {
            var options = Fixture.Create<RecipientUpdateOptions>();

            var result = _service.UpdateBucketRecipient(_jobId, _recipientId, options); 
            Assert.NotNull(result);
            AssertRequest(new HttpMethod("PATCH"), $"/share/buckets/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public async Task UpdateRecipientAsync()
        {
            var options = Fixture.Create<RecipientUpdateOptions>();

            var result = await _service.UpdateBucketRecipientAsync(_jobId, _recipientId, options); 
            Assert.NotNull(result);
            AssertRequest(new HttpMethod("PATCH"), $"/share/buckets/{_jobId}/recipients/{_recipientId}");
        }
        
        [Test]
        public void CreateRecipient()
        {
            var options = Fixture.Create<Recipient>();

            var result = _service.CreateBucketRecipient(_jobId, options); 
            Assert.NotNull(result);
            AssertRequest(HttpMethod.Post, $"/share/buckets/{_jobId}/recipients");
        }
        
        [Test]
        public async Task CreateRecipientAsync()
        {
            var options = Fixture.Create<Recipient>();

            var result = await _service.CreateBucketRecipientAsync(_jobId, options); 
            
            Assert.NotNull(result);
            AssertRequest(HttpMethod.Post, $"/share/buckets/{_jobId}/recipients");
        }

        [Test]
        public void UploadFile()
        {
            _service.UploadFile(_jobId, "1", new byte[10], "file.pdf");
            AssertRequest(HttpMethod.Post, $"/share/buckets/{_jobId}/upload/1");
        }
        
        [Test]
        public async Task UploadFileAsync()
        {
            await _service.UploadFileAsync(_jobId, "1", new byte[10], "file.pdf");
            AssertRequest(HttpMethod.Post, $"/share/buckets/{_jobId}/upload/1");
        }
       
        
        [Test]
        [Ignore("Not yet available in production.")]
        public void  ListRecipients()
        {
            var result = _service.ListRecipients(_jobId);
            Assert.IsNotEmpty(result);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}/recipients");
        }
        
        [Test]
        [Ignore("Not yet available in production.")]
        public async Task ListRecipientsAsync()
        {
            var result = await _service.ListRecipientsAsync(_jobId);
            Assert.IsNotEmpty(result);
            AssertRequest(HttpMethod.Get, $"/share/{_jobId}/recipients");
        }
    }
}