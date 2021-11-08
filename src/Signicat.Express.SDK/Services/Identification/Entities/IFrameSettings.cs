using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class IframeSettings
    {
        /// <summary>
        /// The domain of the site hosting the iframe, this is
        /// used for the CSP policy and must be correct.
        /// </summary>
        [JsonProperty(PropertyName = "Domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Whether web messaging should be used for redirect of the iframe parent.
        /// </summary>
        [JsonProperty(PropertyName = "WebMessaging")]
        public bool? WebMessaging { get; set; }

        /// <summary>
        /// Height of the frame when used in iframe.
        /// </summary>
        [JsonProperty(PropertyName = "Height")]
        public int? Height { get; set; }
    }
}
