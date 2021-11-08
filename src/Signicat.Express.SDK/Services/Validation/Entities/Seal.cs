using System;
using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class Seal
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sealedBy")]
        public string SealedBy { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sealedTimestamp")]
        public DateTime? SealedTimestamp { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public Certificate Certificate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sealValid")]
        public bool? SealValid { get; set; }
    }
}