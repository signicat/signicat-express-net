using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum Language 
    {
        [EnumMember(Value = "en")]
        En = 0,
            
        [EnumMember(Value = "no")]
        No = 1,
        
        [EnumMember(Value = "sv")]
        Sv = 2,
        
        [EnumMember(Value = "da")]
        Da = 3,
        
        [EnumMember(Value = "fi")]
        Fi,
        
        [EnumMember(Value = "de")]
        De,
        
        [EnumMember(Value = "nl")]
        Nl,
    }
}