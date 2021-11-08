using System;
using Newtonsoft.Json;

namespace Signicat.Express.MerchantSign
{   
    public class MerchantSignTransaction
    {
        /// <summary>
        /// Transaction Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Your account Id.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Audit log Id.
        /// </summary>
        [JsonProperty(PropertyName = "auditLogReference")]
        public Guid? AuditLogReference { get; set; }

        /// <summary>
        /// External Reference.
        /// </summary>
        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The OAuth client used in this transaction.
        /// </summary>
        [JsonProperty(PropertyName = "oauthClientId")]
        public string OauthClientId { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// xslt sha256 hash.
        /// </summary>
        [JsonProperty(PropertyName = "xslt")]
        public string Xslt { get; set; }

        /// <summary>
        /// Data to sign sha256 hash.
        /// </summary>
        [JsonProperty(PropertyName = "dataToSign")]
        public string DataToSign { get; set; }

        /// <summary>
        /// Signed data sha256 hash.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// Certificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Log save time.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// For pades retrieval.
        /// </summary>
        [JsonProperty(PropertyName = "signedDocumentId")]
        public Guid? SignedDocumentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "padesCreated")]
        public bool? PadesCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "padesRetrieved")]
        public bool? PadesRetrieved { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "padesDeleted")]
        public bool? PadesDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public string DepartmentId { get; set; }
    }
}
