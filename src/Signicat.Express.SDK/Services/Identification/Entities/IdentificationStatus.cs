using System.Runtime.Serialization;

namespace Idfy.Identification
{
    public enum IdentificationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 0,
    
        [EnumMember(Value = "SUCCESS")]
        Success = 1,
    
        [EnumMember(Value = "ERROR")]
        Error = 2,
    
        [EnumMember(Value = "USERABORTED")]
        UserAborted = 3,
    
        [EnumMember(Value = "INVALIDATED")]
        Invalidated = 4,
    
        [EnumMember(Value = "TIMEOUT")]
        Timeout = 5,
    
        [EnumMember(Value = "CREATED")]
        Created = 6,
    
        [EnumMember(Value = "USERINITIATED")]
        UserInitiated = 7,
    }
}