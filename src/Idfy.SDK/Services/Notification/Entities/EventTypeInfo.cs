using Newtonsoft.Json;

namespace Idfy.Notification
{
    public class EventTypeInfo
    {
        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public EventType? Id { get; set; }

        /// <summary>
        /// Display name of the event
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the event
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
