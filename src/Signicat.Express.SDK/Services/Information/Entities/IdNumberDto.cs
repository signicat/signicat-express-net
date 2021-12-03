
namespace Signicat.Express.Information
{
    /// <summary>
    /// Identity number
    /// </summary>
    public class IdNumberDto
    {
        /// <summary>
        /// The identity number
        /// </summary>
        public string IdNumber { get; set; }
        
        public IdNumberType Type { get; set; }
        
        public Iso3166 Country { get; set; }
    }
    
    /// <summary>
    /// The type of the identity number
    /// </summary>
    public enum IdNumberType
    {
        Unknown = 0,
        NationalIdentityNumber = 1,
        SocialSecurityNumber = 2,
        TaxIdentificationNumber = 3,
        IdentificationDocumentNumber = 4,
    }
}