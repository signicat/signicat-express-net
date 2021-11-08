using Newtonsoft.Json;

namespace Idfy.Notification
{
    public class WebhookConfig
    {
        /// <summary>
        /// The URL to which the payloads will be delivered.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Optional secret used to compute a HMAC hex digest of the payload,
        /// which is passed with the HTTP request as an `X-Idfy-Signature` header.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Determines whether to log webhook delivery attempts. Defaults to `never`.
        /// </summary>
        [JsonProperty(PropertyName = "deliveryLogging")]
        public DeliveryLogging? DeliveryLogging { get; set; }
    }
}
