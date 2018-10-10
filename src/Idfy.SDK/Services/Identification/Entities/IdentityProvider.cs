using System.Runtime.Serialization;

namespace Idfy.Identification
{
    public enum IdentityProvider
    {
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 0,
    
        [EnumMember(Value = "NO_BANKID_MOBILE")]
        NoBankidMobile = 1,
    
        [EnumMember(Value = "NO_BANKID_WEB")]
        NoBankidWeb = 2,
    
        [EnumMember(Value = "SWE_BANKID")]
        SweBankid = 3,
    
        [EnumMember(Value = "SWE_BANKID_MOBILE")]
        SweBankidMobile = 4,
    
        [EnumMember(Value = "NO_BUYPASS")]
        NoBuypass = 5,
    
        [EnumMember(Value = "DA_NEMID")]
        DaNemid = 6,
    
        [EnumMember(Value = "FI_TUPAS")]
        FiTupas = 7,
    }
}