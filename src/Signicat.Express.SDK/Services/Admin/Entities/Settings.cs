using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class Settings
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SMSSender")]
        public string SmsSender { get; set; }
    }
}
