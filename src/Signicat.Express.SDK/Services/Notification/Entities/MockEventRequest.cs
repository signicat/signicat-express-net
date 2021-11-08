using Newtonsoft.Json;

namespace Idfy.Notification
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
