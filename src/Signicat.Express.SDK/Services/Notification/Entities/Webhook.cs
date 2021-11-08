using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Notification
{
    public class Webhook
    {
        /// <summary>
        /// The webhook's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Display name of the webhook.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Determines if the webhook is active.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A list of events that the webhook triggers for.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<string> Events { get; set; }

        /// <summary>
        /// Webhook configuration.
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public WebhookConfig Config { get; set; }

        /// <summary>
        /// Time at which the webhook was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Time at which the webhook was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Last webhook response.
        /// </summary>
        [JsonProperty(PropertyName = "lastResponse")]
        public WebhookResponse LastResponse { get; set; }

        /// <summary>
        /// A list of event tags that the webhook triggers for.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
