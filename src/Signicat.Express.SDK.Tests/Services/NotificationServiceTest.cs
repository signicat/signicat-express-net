using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using NUnit.Framework;
using Signicat.Express.Notification;

namespace Signicat.Express.SDK.Tests
{
    [TestFixture]
    public class NotificationServiceTest : BaseTest
    {
        private NotificationService _notificationService;
        private Guid _eventId;
        
        [SetUp]
        public void Setup()
        {
            _notificationService = new NotificationService();
            _eventId = Guid.NewGuid();
        }
        
        [Test]
        public void ListUnhandledEvents()
        {
            var events = _notificationService.ListUnhandledEvents("document_created", "tag1,tag2");

            Assert.IsNotNull(events);
            AssertRequest(HttpMethod.Get, $"/notification/events?eventType=document_created&tags=tag1,tag2");
        }
        
        [Test]
        public async Task ListUndhandledEventsAsync()
        {
            var events = await _notificationService.ListUnhandledEventsAsync("document_created", "tag1,tag2");

            Assert.IsNotNull(events);
            AssertRequest(HttpMethod.Get, $"/notification/events?eventType=document_created&tags=tag1,tag2");
        }
        
        [Test]
        public void HandleEvent()
        {
            _notificationService.HandleEvent(_eventId);

            AssertRequest(HttpMethod.Post, $"/notification/events/{_eventId}/handle");
        }
        
        [Test]
        public async Task HandleEventAsync()
        {
            await _notificationService.HandleEventAsync(_eventId);

            AssertRequest(HttpMethod.Post, $"/notification/events/{_eventId}/handle");
        }
        
        [Test]
        public void HandleMultipleEvents()
        {
            var events = Fixture.Create<List<Guid>>();
            _notificationService.HandleMultipleEvents(events);

            AssertRequest(HttpMethod.Post, $"/notification/events/handle");
        }
        
        [Test]
        public async Task HandleMultipleEventsAsync()
        {
            var events = Fixture.Create<List<Guid>>();
            await _notificationService.HandleMultipleEventsAsync(events);

            AssertRequest(HttpMethod.Post, $"/notification/events/handle");
        }
        
        [Test]
        public void PeekEvents()
        {
            var events = _notificationService.PeekEvents();
            
            Assert.IsNotNull(events);
            AssertRequest(HttpMethod.Get, $"/notification/events/peek");
        }
        
        [Test]
        public async Task PeekEventsAsync()
        {
            var events = await _notificationService.PeekEventsAsync();
            
            Assert.IsNotNull(events);
            AssertRequest(HttpMethod.Get, $"/notification/events/peek");
        }
        
        [Test]
        public void ClearEvents()
        {
            _notificationService.ClearEvents();
            
            AssertRequest(HttpMethod.Post, $"/notification/events/clear");
        }
        
        [Test]
        public async Task ClearEventsAsync()
        {
            await _notificationService.ClearEventsAsync();
            
            AssertRequest(HttpMethod.Post, $"/notification/events/clear");
        }
        
        [Test]
        public void ListEventTypes()
        {
            var eventTypes = _notificationService.ListEventTypes();
            
            Assert.IsNotNull(eventTypes);
            AssertRequest(HttpMethod.Get, $"/notification/events/types");
        }
        
        [Test]
        public async Task ListEventTypesAsync()
        {
            var eventTypes = await _notificationService.ListEventTypesAsync();
            
            Assert.IsNotNull(eventTypes);
            AssertRequest(HttpMethod.Get, $"/notification/events/types");
        }
        
        [Test]
        public void MockEvent()
        {
            var request = Fixture.Create<MockEventRequest>();
            var @event = _notificationService.MockEvent(request);
            
            Assert.IsNotNull(@event);
            AssertRequest(HttpMethod.Post, $"/notification/events/mock");
        }
        
        [Test]
        public async Task MockEventAsync()
        {
            var request = Fixture.Create<MockEventRequest>();
            var @event = await _notificationService.MockEventAsync(request);
            
            Assert.IsNotNull(@event);
            AssertRequest(HttpMethod.Post, $"/notification/events/mock");
        }
        
        [Test]
        public void GetWebhook()
        {
            var hook = _notificationService.GetWebhook(1);
            
            Assert.IsNotNull(hook);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks/1");
        }
        
        [Test]
        public async Task GetWebhookAsync()
        {
            var hook = await _notificationService.GetWebhookAsync(1);
            
            Assert.IsNotNull(hook);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks/1");
        }
        
        [Test]
        public void DeleteWebhook()
        {
            _notificationService.DeleteWebhook(1);
            
            AssertRequest(HttpMethod.Delete, $"/notification/webhooks/1");
        }
        
        [Test]
        public async Task DeleteWebhookAsync()
        {
            await _notificationService.DeleteWebhookAsync(1);
            
            AssertRequest(HttpMethod.Delete, $"/notification/webhooks/1");
        }
        
        [Test]
        [Ignore("Mock server does not correctly handle date-time strings with `null` value.")]
        public void UpdateWebhook()
        {
            var options = Fixture.Create<WebhookUpdateOptions>();
            var hook = _notificationService.UpdateWebhook(1, options);
            
            Assert.IsNotNull(hook);
            AssertRequest(new HttpMethod("PATCH"), $"/notification/webhooks/1");
        }
        
        [Test]
        [Ignore("Mock server does not correctly handle date-time strings with `null` value.")]
        public async Task UpdateWebhookAsync()
        {
            var options = Fixture.Create<WebhookUpdateOptions>();
            var hook = await _notificationService.UpdateWebhookAsync(1, options);
            
            Assert.IsNotNull(hook);
            AssertRequest(new HttpMethod("PATCH"), $"/notification/webhooks/1");
        }
        
        [Test]
        public void ListWebhooks()
        {
            var hooks = _notificationService.ListWebhooks();
            
            Assert.IsNotNull(hooks);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks");
        }
        
        [Test]
        public async Task ListWebhooksAsync()
        {
            var hooks = await _notificationService.ListWebhooksAsync();
            
            Assert.IsNotNull(hooks);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks");
        }
        
        [Test]
        public void CreateWebhook()
        {
            var options = Fixture.Create<WebhookCreateOptions>();
            var hooks = _notificationService.CreateWebhook(options);
            
            Assert.IsNotNull(hooks);
            AssertRequest(HttpMethod.Post, $"/notification/webhooks");
        }
        
        [Test]
        public async Task CreateWebhookAsync()
        {
            var options = Fixture.Create<WebhookCreateOptions>();
            var hooks = await _notificationService.CreateWebhookAsync(options);
            
            Assert.IsNotNull(hooks);
            AssertRequest(HttpMethod.Post, $"/notification/webhooks");
        }

        [Test]
        public void PingWebhook()
        {
            _notificationService.PingWebhook(1);
            
            AssertRequest(HttpMethod.Post, $"/notification/webhooks/1/ping");
        }
        
        [Test]
        public async Task PingWebhookAsync()
        {
            await _notificationService.PingWebhookAsync(1);
            
            AssertRequest(HttpMethod.Post, $"/notification/webhooks/1/ping");
        }
        
        [Test]
        [Ignore("Swagger document currently displays the wrong response type for this endpoint.")]
        public void ListWebhookDeliveries()
        {
            var deliveries = _notificationService.ListWebhookDeliveries(1);
            
            Assert.IsNotNull(deliveries);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks/1/deliveries");
        }
        
        [Test]
        [Ignore("Swagger document currently displays the wrong response type for this endpoint.")]
        public async Task ListWebhookDeliveriesAsync()
        {
            var deliveries = await _notificationService.ListWebhookDeliveriesAsync(1);
            
            Assert.IsNotNull(deliveries);
            AssertRequest(HttpMethod.Get, $"/notification/webhooks/1/deliveries");
        }
    }
}