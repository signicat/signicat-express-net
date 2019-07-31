using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum IdSessionEventType {
        [EnumMember(Value = "success")]
        Success,
            
        [EnumMember(Value = "failure")]
        Failure,
            
        [EnumMember(Value = "information")]
        Information,
    }
}