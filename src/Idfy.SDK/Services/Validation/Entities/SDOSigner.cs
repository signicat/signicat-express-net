using System;
using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class SDOSigner
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public Certificate Certificate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string Pid { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssn")]
        public string Ssn { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signedTimestamp")]
        public DateTime? SignedTimestamp { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool? Valid { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ocsp")]
        public string Ocsp { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public string Environment { get; set; }
    }
}