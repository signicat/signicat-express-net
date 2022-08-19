using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum IdSessionEventType {
        [EnumMember(Value = "success")]
        Success = 0,
            
        [EnumMember(Value = "failure")]
        Failure = 1,
            
        [EnumMember(Value = "information")]
        Information = 2,
    }
}