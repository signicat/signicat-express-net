using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using Idfy.IdentificationV2;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{
    public class IdentificationV2ServiceTest : BaseTest
    {
        private IdentificationV2Service _identificationV2Service;

        [SetUp]
        public void Setup()
        {
            _identificationV2Service = new IdentificationV2Service();
        }

        [Test]
        public void GetSession()
        {
            var session = _identificationV2Service.GetSession("1");
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions/1");
        }
        
        [Test]
        public async Task GetSessionAsync()
        {
            var session = await _identificationV2Service.GetSessionAsync("1");
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions/1");
        }
        
        [Test]
        public void ListSessions()
        {
            var sessions = _identificationV2Service.ListSessions();
            
            Assert.IsNotNull(sessions);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions");
        }
        
        [Test]
        public async Task ListSessionsAsync()
        {
            var sessions = await _identificationV2Service.ListSessionsAsync();
            
            Assert.IsNotNull(sessions);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions");
        }
        
        [Test]
        public void CreateSession()
        {
            var options = Fixture.Create<IdSessionCreateOptions>();
            var session = _identificationV2Service.CreateSession(options);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions");
        }
        
        [Test]
        public async Task CreateSessionAsync()
        {
            var options = Fixture.Create<IdSessionCreateOptions>();
            var session = await _identificationV2Service.CreateSessionAsync(options);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions");
        }
        
        [Test]
        public void InvalidateSession()
        {
            _identificationV2Service.InvalidateSession("1");
            
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions/1/invalidate");
        }
        
        [Test]
        public async Task InvalidateSessionAsync()
        {
            await _identificationV2Service.InvalidateSessionAsync("1");
            
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions/1/invalidate");
        }
        
        [Test]
        public void ListLanguages()
        {
            var languages = _identificationV2Service.ListLanguages();
            
            Assert.IsNotNull(languages);
            AssertRequest(HttpMethod.Get, "/identification/v2/languages");
        }
        
        [Test]
        public async Task ListLanguagesAsync()
        {
            var languages = await _identificationV2Service.ListLanguagesAsync();
            
            Assert.IsNotNull(languages);
            AssertRequest(HttpMethod.Get, "/identification/v2/languages");
        }
        
        [Test]
        public void ListIdProviders()
        {
            var providers = _identificationV2Service.ListIdProviders();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers");
        }
        
        [Test]
        public async Task ListIdProvidersAsync()
        {
            var providers = await _identificationV2Service.ListIdProvidersAsync();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers");
        }
        
        [Test]
        public void ListIdProvidersForAccount()
        {
            var providers = _identificationV2Service.ListIdProvidersForAccount();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers/account");
        }
        
        [Test]
        public async Task ListIdProvidersForAccountAsync()
        {
            var providers = await _identificationV2Service.ListIdProvidersForAccountAsync();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers/account");
        }
    }
}