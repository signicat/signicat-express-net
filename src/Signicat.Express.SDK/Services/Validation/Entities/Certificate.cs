using System;
using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class Certificate 
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuerName")]
        public string IssuerName { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectName")]
        public string SubjectName { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validFromDate")]
        public DateTime? ValidFromDate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validToDate")]
        public DateTime? ValidToDate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionNumber")]
        public string VersionNumber { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyAlgorithm")]
        public string KeyAlgorithm { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keySize")]
        public string KeySize { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueId")]
        public string UniqueId { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originator")]
        public string Originator { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bankName")]
        public string BankName { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policyOid")]
        public string PolicyOid { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commonName")]
        public string CommonName { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signingCertficate")]
        public string SigningCertficate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "x509Certificate")]
        public X509Certificate X509Certificate { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyUsage")]
        public string KeyUsage { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public object EmailAddress { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signingTime")]
        public DateTime? SigningTime { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificateType")]
        public CertificateType? CertificateType { get; set; }
    }
}