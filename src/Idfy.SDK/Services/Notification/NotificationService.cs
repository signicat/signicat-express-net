using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.Notification
{
    /// <summary>
    /// Manage events that are raised when something happens in your account.
    /// </summary>
    public class NotificationService : IdfyBaseService
    {
        public NotificationService()
        {
        }

        public NotificationService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieves up to 100 unhandled events for your account. After you retrieve this list the events will be "locked" for 10 minutes to give you time to handle them.
        /// Please handle the events using one of the endpoints in this API to avoid retrieving the same events multiple times.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public IList<Event> ListUnhandledEvents(string eventType = null, string tags = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Notification}/events", new Dictionary<string, object>()
            {
                {"eventType", eventType},
                {"tags", tags}
            });

            return Get<IList<Event>>(url);
        }
        
        /// <summary>
        /// Retrieves up to 100 unhandled events for your account. After you retrieve this list the events will be "locked" for 10 minutes to give you time to handle them.
        /// Please handle the events using one of the endpoints in this API to avoid retrieving the same events multiple times.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public async Task<IList<Event>> ListUnhandledEventsAsync(string eventType = null, string tags = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Notification}/events", new Dictionary<string, object>()
            {
                {"eventType", eventType},
                {"tags", tags}
            });

            return await GetAsync<IList<Event>>(url);
        }

        /// <summary>
        /// Marks the status of an event as handled.
        /// </summary>
        /// <param name="eventId"></param>
        public void HandleEvent(Guid eventId)
        {
            Post($"{Urls.Notification}/events/{eventId}/handle");
        }
        
        /// <summary>
        /// Marks the status of an event as handled.
        /// </summary>
        /// <param name="eventId"></param>
        public async Task HandleEventAsync(Guid eventId)
        {
            await PostAsync($"{Urls.Notification}/events/{eventId}/handle");
        }

        /// <summary>
        /// Marks the status of a batch of events as handled.
        /// </summary>
        /// <param name="eventIds"></param>
        public void HandleMultipleEvents(IList<Guid> eventIds)
        {
            Post($"{Urls.Notification}/events/handle", eventIds);
        }
        
        /// <summary>
        /// Marks the status of a batch of events as handled.
        /// </summary>
        /// <param name="eventIds"></param>
        public async Task HandleMultipleEventsAsync(IList<Guid> eventIds)
        {
            await PostAsync($"{Urls.Notification}/events/handle", eventIds);
        }

        /// <summary>
        /// Peeks the top 100 unhandled events regardless if they are locked or not. Don't use this endpoint to handle events.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public IList<Event> PeekEvents(string eventType = null, string tags = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Notification}/events/peek", new Dictionary<string, object>()
            {
                {"eventType", eventType},
                {"tags", tags}
            });

            return Get<IList<Event>>(url);
        }
        
        /// <summary>
        /// Peeks the top 100 unhandled events regardless if they are locked or not. Don't use this endpoint to handle events.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public async Task<IList<Event>> PeekEventsAsync(string eventType = null, string tags = null)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Notification}/events/peek", new Dictionary<string, object>()
            {
                {"eventType", eventType},
                {"tags", tags}
            });

            return await GetAsync<IList<Event>>(url);
        }

        /// <summary>
        /// Clears all events for your account.
        /// </summary>
        public void ClearEvents()
        {
            Post($"{Urls.Notification}/events/clear");
        }
        
        /// <summary>
        /// Clears all events for your account.
        /// </summary>
        public async Task ClearEventsAsync()
        {
            await PostAsync($"{Urls.Notification}/events/clear");
        }

        /// <summary>
        /// Returns a list of all available event types.
        /// </summary>
        /// <returns></returns>
        public IList<EventTypeInfo> ListEventTypes()
        {
            return Get<IList<EventTypeInfo>>($"{Urls.Notification}/events/types");
        }
        
        /// <summary>
        /// Returns a list of all available event types.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<EventTypeInfo>> ListEventTypesAsync()
        {
            return await GetAsync<IList<EventTypeInfo>>($"{Urls.Notification}/events/types");
        }

        /// <summary>
        /// Creates a mock event with a sample payload. Can be used to test your event handling code.
        /// </summary>
        /// <param name="mockEventRequest"></param>
        /// <returns></returns>
        public Event MockEvent(MockEventRequest mockEventRequest)
        {
            return Post<Event>($"{Urls.Notification}/events/mock", mockEventRequest);
        }
        
        /// <summary>
        /// Creates a mock event with a sample payload. Can be used to test your event handling code.
        /// </summary>
        /// <param name="mockEventRequest"></param>
        /// <returns></returns>
        public async Task<Event> MockEventAsync(MockEventRequest mockEventRequest)
        {
            return await PostAsync<Event>($"{Urls.Notification}/events/mock", mockEventRequest);
        }

        /// <summary>
        /// Retrieves the details of a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Webhook GetWebhook(int id)
        {
            return Get<Webhook>($"{Urls.Notification}/webhooks/{id}");
        }
        
        /// <summary>
        /// Retrieves the details of a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Webhook> GetWebhookAsync(int id)
        {
            return await GetAsync<Webhook>($"{Urls.Notification}/webhooks/{id}");
        }

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteWebhook(int id)
        {
            Delete($"{Urls.Notification}/webhooks/{id}");
        }
        
        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="id"></param>
        public async Task DeleteWebhookAsync(int id)
        {
            await DeleteAsync($"{Urls.Notification}/webhooks/{id}");
        }

        /// <summary>
        /// Updates the specified webhook with the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webhookUpdateOptions"></param>
        /// <returns></returns>
        public Webhook UpdateWebhook(int id, WebhookUpdateOptions webhookUpdateOptions)
        {
            return Patch<Webhook>($"{Urls.Notification}/webhooks/{id}", webhookUpdateOptions);
        }
        
        /// <summary>
        /// Updates the specified webhook with the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webhookUpdateOptions"></param>
        /// <returns></returns>
        public async Task<Webhook> UpdateWebhookAsync(int id, WebhookUpdateOptions webhookUpdateOptions)
        {
            return await PatchAsync<Webhook>($"{Urls.Notification}/webhooks/{id}", webhookUpdateOptions);
        }

        /// <summary>
        /// Returns a list of all your webhooks.
        /// </summary>
        /// <returns></returns>
        public IList<Webhook> ListWebhooks()
        {
            return Get<IList<Webhook>>($"{Urls.Notification}/webhooks");
        }
        
        /// <summary>
        /// Returns a list of all your webhooks.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Webhook>> ListWebhooksAsync()
        {
            return await GetAsync<IList<Webhook>>($"{Urls.Notification}/webhooks");
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="webhookCreateOptions"></param>
        /// <returns></returns>
        public Webhook CreateWebhook(WebhookCreateOptions webhookCreateOptions)
        {
            return Post<Webhook>($"{Urls.Notification}/webhooks", webhookCreateOptions);
        }
        
        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="webhookCreateOptions"></param>
        /// <returns></returns>
        public async Task<Webhook> CreateWebhookAsync(WebhookCreateOptions webhookCreateOptions)
        {
            return await PostAsync<Webhook>($"{Urls.Notification}/webhooks", webhookCreateOptions);
        }

        /// <summary>
        /// Triggers a ping event to be sent to the webhook.
        /// </summary>
        /// <param name="id"></param>
        public void PingWebhook(int id)
        {
            Post($"{Urls.Notification}/webhooks/{id}/ping");
        }
        
        /// <summary>
        /// Triggers a ping event to be sent to the webhook.
        /// </summary>
        /// <param name="id"></param>
        public async Task PingWebhookAsync(int id)
        {
            await PostAsync($"{Urls.Notification}/webhooks/{id}/ping");
        }

        /// <summary>
        /// Returns the 10 most recent delivery attempts for a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<WebhookDelivery> ListWebhookDeliveries(int id)
        {
            return Get<IList<WebhookDelivery>>($"{Urls.Notification}/webhooks/{id}/deliveries");
        }
        
        /// <summary>
        /// Returns the 10 most recent delivery attempts for a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IList<WebhookDelivery>> ListWebhookDeliveriesAsync(int id)
        {
            return await GetAsync<IList<WebhookDelivery>>($"{Urls.Notification}/webhooks/{id}/deliveries");
        }
    }
}