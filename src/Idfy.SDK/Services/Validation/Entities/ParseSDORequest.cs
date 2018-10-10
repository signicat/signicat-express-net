using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class ParseSDORequest 
    {
        /// <summary>
        /// Base 64 encoded SDO (Signed document)
        /// </summary>
        [JsonProperty(PropertyName = "sdoData")]
        public string SdoData { get; set; }
    
        /// <summary>
        /// The service reference for the signing. Will be used for auditlog, and invoicing
        /// </summary>
        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }
    
        /// <summary>
        /// Fetch social security number (Requires valid scope)
        /// </summary>
        [JsonProperty(PropertyName = "fetchSSN")]
        public bool? FetchSSN { get; set; }
    }
}