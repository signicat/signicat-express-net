using System;
using Newtonsoft.Json;

namespace Signicat.Express.Notification
{
    public class WebhookDelivery
    {
        /// <summary>
        /// The webhook delivery's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// The webhook's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "webhookId")]
        public int? WebhookId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eventId")]
        public Guid? EventId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "elapsedMs")]
        public long? ElapsedMs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestHeaders")]
        public object RequestHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestBody")]
        public object RequestBody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "responseHeaders")]
        public object ResponseHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "responseBody")]
        public object ResponseBody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "responseStatusCode")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "responseMessage")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
