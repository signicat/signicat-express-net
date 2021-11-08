using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Notification
{
    public class WebhookCreateOptions
    {
        /// <summary>
        /// Display name of the webhook.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Determines whether the webhook is active or not.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

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
        /// An optional list of event tags that the webhook triggers for.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
