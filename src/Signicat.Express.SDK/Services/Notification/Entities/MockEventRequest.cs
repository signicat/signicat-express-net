using Newtonsoft.Json;

namespace Signicat.Express.Notification
{
    public class MockEventRequest
    {
        /// <summary>
        /// Event type to mock
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }
    }
}
