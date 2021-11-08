using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class ParseSDOResponse 
    {
        /// <summary>
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    
        /// <summary>
        /// Reference to audit log
        /// </summary>
        [JsonProperty("auditId")]
        public Guid? AuditId { get; set; }
    
        /// <summary>
        /// Is the signatures valid
        /// </summary>
        [JsonProperty("signersValid")]
        public bool? SignersValid { get; set; }
    
        /// <summary>
        /// Is the sealing of the SDO valid
        /// </summary>
        [JsonProperty("seal")]
        public Seal Seal { get; set; }
    
        /// <summary>
        /// Signers list
        /// </summary>
        [JsonProperty("signers")]
        public IList<SDOSigner> Signers { get; set; }
    
        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }
    
        /// <summary>
        /// Error messages
        /// </summary>
        [JsonProperty("validationError")]
        public ValidationError ValidationError { get; set; }
    
        /// <summary>
        /// Original data from document (base64 string)
        /// </summary>
        [JsonProperty("signedData")]
        public string SignedData { get; set; }
    }
}