using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class ValidateSDOResponse 
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }
    
        /// <summary>
        /// Is the SDO valid.
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool? Valid { get; set; }
    
        /// <summary>
        /// Is the Seal of the SDO valid.
        /// </summary>
        [JsonProperty(PropertyName = "seal")]
        public Seal Seal { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signers")]
        public IList<ValidatedSigner> Signers { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationError")]
        public ValidationError ValidationError { get; set; }
    
        /// <summary>
        /// The AuditId vil only be set for users with an account on the API.
        /// </summary>
        [JsonProperty(PropertyName = "auditId")]
        public Guid? AuditId { get; set; } 
    }
}