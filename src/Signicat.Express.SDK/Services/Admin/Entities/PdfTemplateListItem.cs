using System;
using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class PdfTemplateListItem
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the Pdf template
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Timestamp when the template is last edited
        /// </summary>
        [JsonProperty(PropertyName = "LastEdited")]
        public DateTime? LastEdited { get; set; }
    }
}
