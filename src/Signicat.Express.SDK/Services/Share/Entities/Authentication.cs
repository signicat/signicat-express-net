namespace Signicat.Express.Share
{
    public class Authentication
    {
        /// <summary>
        /// The identity provider.
        /// </summary>
        public IdentityProvider IdentityProvider { get; set; }
        
        /// <summary>
        /// The uniqueID from the eID. This ID is unique for the user and is the same every time the user logs on. This is not a sensitive ID
        /// and you could store this to identify the user in you database.
        /// </summary>
        public string IdentityProviderUniqueId { get; set; }
        
        /// <summary>
        /// Social security number.
        /// </summary>
        public string Ssn { get; set; }
        
        /// <summary>
        /// The user's date of birth (ddMMyy).
        /// </summary>
        public string DateOfBirth { get; set; }

    }
} 