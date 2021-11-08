using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class ValidateSDORequest
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
        /// Check that the original data matches the sdo data (optional, base64 encoded)
        /// </summary>
        [JsonProperty(PropertyName = "dataToValidate")]
        public string DataToValidate { get; set; }
    
        /// <summary>
        /// Add signers to validate (optional)
        /// </summary>
        [JsonProperty(PropertyName = "signersToValidate")]
        public IList<Signer> SignersToValidate { get; set; } 
    }
}