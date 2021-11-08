using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class LogItemList
    {
        /// <summary>
        /// Link to the next results.
        /// </summary>
        [JsonProperty(PropertyName = "NextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// The total amount of links (pages) for the list.
        /// </summary>
        [JsonProperty(PropertyName = "TotalLinks")]
        public int? TotalLinks { get; set; }

        /// <summary>
        /// List of results.
        /// </summary>
        [JsonProperty(PropertyName = "List")]
        public IList<IdentificationLogItem> List { get; set; }
    }
}
