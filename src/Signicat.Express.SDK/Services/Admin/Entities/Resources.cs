using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class Resources
    {
        /// <summary>
        /// The logo uploaded to this account
        /// </summary>
        [JsonProperty(PropertyName = "LogoUrl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Custom css uploaded to this account
        /// </summary>
        [JsonProperty(PropertyName = "CssUrl")]
        public string CssUrl { get; set; }
    }
}
