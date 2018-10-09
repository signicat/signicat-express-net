using System;
using Newtonsoft.Json;

namespace Idfy.Notification
{
    public class WebhookResponse
    {
        /// <summary>
        /// The status code returned by the webhook endpoint on last delivery attempt.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// The message returned by the webhook endpoint on last delivery attempt.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Time at which the last delivery attempt was made.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}
