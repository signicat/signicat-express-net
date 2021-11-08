using System;
using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    /// <summary>
    /// Dealer information
    /// </summary>
    public class DealerInfo
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }
    }
}
