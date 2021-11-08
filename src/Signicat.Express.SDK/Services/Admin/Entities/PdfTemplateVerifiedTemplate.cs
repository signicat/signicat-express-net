using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class PdfTemplateVerifiedTemplate
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "en")]
        public string En { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public string No { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sv")]
        public string Sv { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "da")]
        public string Da { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fi")]
        public string Fi { get; set; }

    }
}
