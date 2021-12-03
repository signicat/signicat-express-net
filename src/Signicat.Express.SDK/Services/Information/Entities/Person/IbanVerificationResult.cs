namespace Signicat.Express.Information.Person
{
    /// <summary>
    /// Iban validation
    /// </summary>
    public class IbanVerificationResult
    {   
        /// <summary>
        /// Iban number
        /// </summary>
        public string Iban { get; set; }
        
        /// <summary>
        /// If the Iban is valid
        /// </summary>
        public bool? IsValidIban { get; set; }

        /// <summary>
        /// Client details
        /// </summary>
        public ValidationDetails ValidationDetails { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        public Iso3166 Country { get; set; }
        
        /// <summary>
        /// Account details 
        /// </summary>
        public AccountDetails AccountDetails { get; set; }
        
        public Metadata Metadata { get; set; }

    }
}
