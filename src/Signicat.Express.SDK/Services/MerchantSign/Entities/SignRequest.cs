using Newtonsoft.Json;

namespace Signicat.Express.MerchantSign
{
    public class SignRequest
    {
        /// <summary>
        /// Base 64 encoded data.
        /// </summary>
        [JsonProperty(PropertyName = "dataToSign")]
        public string DataToSign { get; set; }

        /// <summary>
        /// Base 64 encoded xslt (optional).
        /// </summary>
        [JsonProperty(PropertyName = "xslt")]
        public string Xslt { get; set; }

        /// <summary>
        /// Format of data (i.e xml).
        /// </summary>
        [JsonProperty(PropertyName = "dataFormat")]
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataEncodingFormat")]
        public DataEncodingFormat? DataEncodingFormat { get; set; }

        /// <summary>
        /// The service reference for the signing. Will be used for auditlog and invoicing.
        /// </summary>
        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Optional, if not set the default setting for the account will be used.
        /// </summary>
        [JsonProperty(PropertyName = "signingFormat")]
        public SigningFormat? SigningFormat { get; set; }

        /// <summary>
        /// Set this if a specific department should be invoiced.
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public string DepartmentId { get; set; }
    }
}
