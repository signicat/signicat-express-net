using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class PdfTemplateLabels
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "en")]
        public IDictionary<string, string> En { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public IDictionary<string, string> No { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sv")]
        public IDictionary<string, string> Sv { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "da")]
        public IDictionary<string, string> Da { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fi")]
        public IDictionary<string, string> Fi { get; set; }
    }
}
