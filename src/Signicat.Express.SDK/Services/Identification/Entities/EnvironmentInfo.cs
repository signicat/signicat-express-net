using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class EnvironmentInfo
    {
        /// <summary>
        /// The users user-agent (browser/device).
        /// </summary>
        [JsonProperty(PropertyName = "UserAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The IP-address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "IPAddress")]
        public string IPAddress { get; set; }

    }
}
