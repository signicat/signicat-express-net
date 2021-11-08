using System;

namespace Signicat.Express.Signature
{
    public class ExtendedDocumentSignature 
    {
        /// <summary>
        /// The signer's unique identifier.
        /// </summary>
        public Guid? SignerId { get; set; }
    
        /// <summary>
        /// Your reference for the signer.
        /// </summary>
        public string ExternalSignerId { get; set; }
    
        /// <summary>
        /// The signature method used to sign the document.
        /// </summary>
        public SignatureMethod? SignatureMethod { get; set; }
    
        /// <summary>
        /// The signer's full name, retrieved from the signature-method provider.
        /// </summary>
        public string FullName { get; set; }
    
        /// <summary>
        /// The signer's first name.
        /// </summary>
        public string FirstName { get; set; }
    
        /// <summary>
        /// The signer's last name.
        /// </summary>
        public string LastName { get; set; }
    
        /// <summary>
        /// The signer's middle name.
        /// </summary>
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Time at which the signature was registered (ISO 8601).
        /// </summary>
        public DateTime? SignedTime { get; set; }
    
        /// <summary>
        /// The signer's date of birth (ddMMyy).
        /// </summary>
        public string DateOfBirth { get; set; }
    
        /// <summary>
        /// The signature method unique ID.
        /// </summary>
        public string SignatureMethodUniqueId { get; set; }
    
        /// <summary>
        /// The signer's social security number. Will be retrieved only when `getSocialSecurityNumber` is specified when creating the document.
        /// </summary>
        public SocialSecurityNumber SocialSecurityNumber { get; set; }
    
        /// <summary>
        /// The IP address of the signer.
        /// </summary>    
        public string ClientIp { get; set; }
    }
}