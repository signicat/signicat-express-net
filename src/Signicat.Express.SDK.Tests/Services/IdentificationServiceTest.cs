using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using Idfy.Identification;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{
    [TestFixture]
    public class IdentificationServiceTest : BaseTest
    {
        private IdentificationService _identificationService;
        
        [SetUp]
        public void Setup()
        {
            _identificationService = new IdentificationService();
        }
        
        [Test]
        public void GetSession()
        {
            var session = _identificationService.GetSession("1");

            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/session?requestId=1");
        }

        [Test]
        public async Task GetSessionAsync()
        {
            var session = await _identificationService.GetSessionAsync("1");

            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/session?requestId=1");
        }
        
        [Test]
        public void CreateSession()
        {
            var request = Fixture.Create<CreateIdentificationRequest>();
            var session = _identificationService.CreateSession(request);

            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/session");
        }

        [Test]
        public async Task CreateSessionAsync()
        {
            var request = Fixture.Create<CreateIdentificationRequest>();
            var session = await _identificationService.CreateSessionAsync(request);

            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/session");
        }
        
        [Test]
        public void GetSessionStatus()
        {
            var status = _identificationService.GetSessionStatus("1");

            Assert.IsNotNull(status);
            AssertRequest(HttpMethod.Get, "/identification/session/status?requestId=1");
        }

        [Test]
        public async Task GetSessionStatusAsync()
        {
            var status = await _identificationService.GetSessionStatusAsync("1");

            Assert.IsNotNull(status);
            AssertRequest(HttpMethod.Get, "/identification/session/status?requestId=1");
        }
        
        [Test]
        public void InvalidateSession()
        {
            _identificationService.InvalidateSession("1");

            AssertRequest(HttpMethod.Put, "/identification/session/invalidate?requestId=1");
        }

        [Test]
        public async Task InvalidateSessionAsync()
        {
            await _identificationService.InvalidateSessionAsync("1");

            AssertRequest(HttpMethod.Put, "/identification/session/invalidate?requestId=1");
        }
        
        [Test]
        public void GetLogEntry()
        {
            var log = _identificationService.GetLogEntry("1");

            Assert.IsNotNull(log);
            AssertRequest(HttpMethod.Get, "/identification/log/requestId/1");
        }

        [Test]
        public async Task GetLogEntryAsync()
        {
            var log = await _identificationService.GetLogEntryAsync("1");

            Assert.IsNotNull(log);
            AssertRequest(HttpMethod.Get, "/identification/log/requestId/1");
        }
        
        [Test]
        public void ListLogEntries()
        {
            var logs = _identificationService.ListLogEntries(2000, 1);

            Assert.IsNotNull(logs);
            AssertRequest(HttpMethod.Get, "/identification/log/filter/2000?month=1");
        }

        [Test]
        public async Task ListLogEntriesAsync()
        {
            var logs = await _identificationService.ListLogEntriesAsync(2000, 1);

            Assert.IsNotNull(logs);
            AssertRequest(HttpMethod.Get, "/identification/log/filter/2000?month=1");
        }

        [Test]
        public void CreateBankIdMobileSession()
        {
            var request = Fixture.Create<CreateBankIDMobileRequest>();
            var session = _identificationService.CreateBankIdMobileSession(request);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/no/bankid/mobile");
        }
        
        [Test]
        public async Task CreateBankIdMobileSessionAsync()
        {
            var request = Fixture.Create<CreateBankIDMobileRequest>();
            var session = await _identificationService.CreateBankIdMobileSessionAsync(request);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/no/bankid/mobile");
        }
    }
}