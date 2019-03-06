namespace Idfy.Share.Entities
{
    public class Authentication
    {
        /// <summary>
        ///The identity provider type (Norwegian BanKID, SwedishBankID, Nemid, etc)
        /// </summary>
        public IdentityProviderType IdentityProvider { get; set; }
        
        /// <summary>
        /// The uniqueID from the e-ID, this ID is unique for the user and is the same every time the user logs on. This is not a sensitive ID
        /// and you could store this to identify the user in you database. Remark: The Swedish BankID do not have an unique ID.
        /// </summary>
        public string IdentityProviderUniqueId { get; set; }
        
        /// <summary>
        /// Social security number 
        /// </summary>
        public string Ssn { get; set; }
        
        /// <summary>
        /// The users date of birth format ddMMyy
        /// </summary>
        public string DateOfBirth { get; set; }

    }
}