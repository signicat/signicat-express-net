using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Signicat.Express.Notification
{
    public interface INotificationService
    {
        /// <summary>
        /// Retrieves up to 100 unhandled events for your account. After you retrieve this list the events will be "locked" for 10 minutes to give you time to handle them.
        /// Please handle the events using one of the endpoints in this API to avoid retrieving the same events multiple times.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        IList<Event> ListUnhandledEvents(string eventType = null, string tags = null);

        /// <summary>
        /// Retrieves up to 100 unhandled events for your account. After you retrieve this list the events will be "locked" for 10 minutes to give you time to handle them.
        /// Please handle the events using one of the endpoints in this API to avoid retrieving the same events multiple times.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        Task<IList<Event>> ListUnhandledEventsAsync(string eventType = null, string tags = null);

        /// <summary>
        /// Marks the status of an event as handled.
        /// </summary>
        /// <param name="eventId"></param>
        void HandleEvent(Guid eventId);

        /// <summary>
        /// Marks the status of an event as handled.
        /// </summary>
        /// <param name="eventId"></param>
        Task HandleEventAsync(Guid eventId);

        /// <summary>
        /// Marks the status of a batch of events as handled.
        /// </summary>
        /// <param name="eventIds"></param>
        void HandleMultipleEvents(IList<Guid> eventIds);

        /// <summary>
        /// Marks the status of a batch of events as handled.
        /// </summary>
        /// <param name="eventIds"></param>
        Task HandleMultipleEventsAsync(IList<Guid> eventIds);

        /// <summary>
        /// Peeks the top 100 unhandled events regardless if they are locked or not. Don't use this endpoint to handle events.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        IList<Event> PeekEvents(string eventType = null, string tags = null);

        /// <summary>
        /// Peeks the top 100 unhandled events regardless if they are locked or not. Don't use this endpoint to handle events.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        Task<IList<Event>> PeekEventsAsync(string eventType = null, string tags = null);

        /// <summary>
        /// Clears all events for your account.
        /// </summary>
        void ClearEvents();

        /// <summary>
        /// Clears all events for your account.
        /// </summary>
        Task ClearEventsAsync();

        /// <summary>
        /// Returns a list of all available event types.
        /// </summary>
        /// <returns></returns>
        IList<EventTypeInfo> ListEventTypes();

        /// <summary>
        /// Returns a list of all available event types.
        /// </summary>
        /// <returns></returns>
        Task<IList<EventTypeInfo>> ListEventTypesAsync();

        /// <summary>
        /// Creates a mock event with a sample payload. Can be used to test your event handling code.
        /// </summary>
        /// <param name="mockEventRequest"></param>
        /// <returns></returns>
        Event MockEvent(MockEventRequest mockEventRequest);

        /// <summary>
        /// Creates a mock event with a sample payload. Can be used to test your event handling code.
        /// </summary>
        /// <param name="mockEventRequest"></param>
        /// <returns></returns>
        Task<Event> MockEventAsync(MockEventRequest mockEventRequest);

        /// <summary>
        /// Retrieves the details of a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Webhook GetWebhook(int id);

        /// <summary>
        /// Retrieves the details of a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Webhook> GetWebhookAsync(int id);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="id"></param>
        void DeleteWebhook(int id);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="id"></param>
        Task DeleteWebhookAsync(int id);

        /// <summary>
        /// Updates the specified webhook with the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webhookUpdateOptions"></param>
        /// <returns></returns>
        Webhook UpdateWebhook(int id, WebhookUpdateOptions webhookUpdateOptions);

        /// <summary>
        /// Updates the specified webhook with the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webhookUpdateOptions"></param>
        /// <returns></returns>
        Task<Webhook> UpdateWebhookAsync(int id, WebhookUpdateOptions webhookUpdateOptions);

        /// <summary>
        /// Returns a list of all your webhooks.
        /// </summary>
        /// <returns></returns>
        IList<Webhook> ListWebhooks();

        /// <summary>
        /// Returns a list of all your webhooks.
        /// </summary>
        /// <returns></returns>
        Task<IList<Webhook>> ListWebhooksAsync();

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="webhookCreateOptions"></param>
        /// <returns></returns>
        Webhook CreateWebhook(WebhookCreateOptions webhookCreateOptions);

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="webhookCreateOptions"></param>
        /// <returns></returns>
        Task<Webhook> CreateWebhookAsync(WebhookCreateOptions webhookCreateOptions);

        /// <summary>
        /// Triggers a ping event to be sent to the webhook.
        /// </summary>
        /// <param name="id"></param>
        void PingWebhook(int id);

        /// <summary>
        /// Triggers a ping event to be sent to the webhook.
        /// </summary>
        /// <param name="id"></param>
        Task PingWebhookAsync(int id);

        /// <summary>
        /// Returns the 10 most recent delivery attempts for a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<WebhookDelivery> ListWebhookDeliveries(int id);

        /// <summary>
        /// Returns the 10 most recent delivery attempts for a single webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IList<WebhookDelivery>> ListWebhookDeliveriesAsync(int id);
    }
}