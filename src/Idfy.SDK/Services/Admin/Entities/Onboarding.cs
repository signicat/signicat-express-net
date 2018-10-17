using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class Onboarding
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Heading")]
        public string Heading { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadParagraph")]
        public string LeadParagraph { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogoUrl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReturnUrl")]
        public string ReturnUrl { get; set; }
    }
}
