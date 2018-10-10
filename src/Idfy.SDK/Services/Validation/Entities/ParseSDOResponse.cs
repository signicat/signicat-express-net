using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class ParseSDOResponse 
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }
    
        /// <summary>
        /// Reference to audit log
        /// </summary>
        [JsonProperty(PropertyName = "auditId")]
        public Guid? AuditId { get; set; }
    
        /// <summary>
        /// Is the signatures valid
        /// </summary>
        [JsonProperty(PropertyName = "signersValid")]
        public bool? SignersValid { get; set; }
    
        /// <summary>
        /// Is the sealing of the SDO valid
        /// </summary>
        [JsonProperty(PropertyName = "seal")]
        public Seal Seal { get; set; }
    
        /// <summary>
        /// Signers list
        /// </summary>
        public IList<SDOSigner> Signers { get; set; }
    
        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
    
        /// <summary>
        /// Error messages
        /// </summary>
        [JsonProperty(PropertyName = "validationError")]
        public ValidationError ValidationError { get; set; }
    
        /// <summary>
        /// Original data from document (base64 string)
        /// </summary>
        [JsonProperty(PropertyName = "signedData")]
        public string SignedData { get; set; }
    }
}