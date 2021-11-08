using System.Runtime.Serialization;

namespace Signicat.Express.Validation
{
    public enum IdentificatorType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
    
        [EnumMember(Value = "BankIDUniqueId")]
        BankIDUniqueId = 1,
    
        [EnumMember(Value = "SSN")]
        SSN = 2,
    
        [EnumMember(Value = "OrganizationNumber")]
        OrganizationNumber = 3,
    }
}