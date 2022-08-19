using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using NUnit.Framework;
using Signicat.Express.Authentication;

namespace Signicat.Express.SDK.Tests
{
    public class AuthenticationServiceTest : BaseTest
    {
        private AuthenticationService _authenticationService;

        [SetUp]
        public void Setup()
        {
            _authenticationService = new AuthenticationService();
        }

        [Test]
        public void GetSession()
        {
            var session = _authenticationService.GetSession("1");
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions/1");
        }
        
        [Test]
        public async Task GetSessionAsync()
        {
            var session = await _authenticationService.GetSessionAsync("1");
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions/1");
        }
        
        [Test]
        public void ListSessions()
        {
            var sessions = _authenticationService.ListSessions();
            
            Assert.IsNotNull(sessions);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions");
        }
        
        [Test]
        public async Task ListSessionsAsync()
        {
            var sessions = await _authenticationService.ListSessionsAsync();
            
            Assert.IsNotNull(sessions);
            AssertRequest(HttpMethod.Get, "/identification/v2/sessions");
        }
        
        [Test]
        public void CreateSession()
        {
            var options = Fixture.Create<IdSessionCreateOptions>();
            var session = _authenticationService.CreateSession(options);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions");
        }
        
        [Test]
        public async Task CreateSessionAsync()
        {
            var options = Fixture.Create<IdSessionCreateOptions>();
            var session = await _authenticationService.CreateSessionAsync(options);
            
            Assert.IsNotNull(session);
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions");
        }
        
        [Test]
        public void InvalidateSession()
        {
            _authenticationService.InvalidateSession("1");
            
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions/1/invalidate");
        }
        
        [Test]
        public async Task InvalidateSessionAsync()
        {
            await _authenticationService.InvalidateSessionAsync("1");
            
            AssertRequest(HttpMethod.Post, "/identification/v2/sessions/1/invalidate");
        }
        
        [Test]
        public void ListLanguages()
        {
            var languages = _authenticationService.ListLanguages();
            
            Assert.IsNotNull(languages);
            AssertRequest(HttpMethod.Get, "/identification/v2/languages");
        }
        
        [Test]
        public async Task ListLanguagesAsync()
        {
            var languages = await _authenticationService.ListLanguagesAsync();
            
            Assert.IsNotNull(languages);
            AssertRequest(HttpMethod.Get, "/identification/v2/languages");
        }
        
        [Test]
        public void ListIdProviders()
        {
            var providers = _authenticationService.ListIdProviders();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers");
        }
        
        [Test]
        public async Task ListIdProvidersAsync()
        {
            var providers = await _authenticationService.ListIdProvidersAsync();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers");
        }
        
        [Test]
        public void ListIdProvidersForAccount()
        {
            var providers = _authenticationService.ListIdProvidersForAccount();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers/account");
        }
        
        [Test]
        public async Task ListIdProvidersForAccountAsync()
        {
            var providers = await _authenticationService.ListIdProvidersForAccountAsync();
            
            Assert.IsNotNull(providers);
            AssertRequest(HttpMethod.Get, "/identification/v2/id-providers/account");
        }
    }
}