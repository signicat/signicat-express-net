using System.Runtime.Serialization;

namespace Signicat.Express.Identification
{
    public enum Language
    {
        [EnumMember(Value = "NO")]
        NO = 0,
    
        [EnumMember(Value = "EN")]
        EN = 1,
    
        [EnumMember(Value = "SV")]
        SV = 2,
    
        [EnumMember(Value = "DA")]
        DA = 3,
    
        [EnumMember(Value = "FI")]
        FI = 4,
    }
}