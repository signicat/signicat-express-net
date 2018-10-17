using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class Settings
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SMSSender")]
        public string SmsSender { get; set; }
    }
}
