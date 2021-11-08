using System;
using Newtonsoft.Json;

namespace Signicat.Express.MerchantSign
{
    public class SignResponse
    {
        /// <summary>
        /// Base 64 encoded signed data.
        /// </summary>
        [JsonProperty(PropertyName = "signedData")]
        public string SignedData { get; set; }

        /// <summary>
        /// Reference Id to audit log.
        /// </summary>
        [JsonProperty(PropertyName = "auditLogReference")]
        public Guid? AuditLogReference { get; set; }

        /// <summary>
        /// Signing format.
        /// </summary>
        [JsonProperty(PropertyName = "signingFormat")]
        public SigningFormat? SigningFormat { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        /// <summary>
        /// Signed with certificate.
        /// </summary>
        [JsonProperty(PropertyName = "signCertificateBase64String")]
        public string SignCertificateBase64String { get; set; }

        /// <summary>
        /// Id to look up the transaction at a later time.
        /// </summary>
        [JsonProperty(PropertyName = "transactionId")]
        public Guid? TransactionId { get; set; }

        /// <summary>
        /// Id to retrieve signed file (pades).
        /// </summary>
        [JsonProperty(PropertyName = "signedDocumentId")]
        public Guid? SignedDocumentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataEncodingFormat")]
        public DataEncodingFormat? DataEncodingFormat { get; set; }
    }
}
