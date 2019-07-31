using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum IdSessionStatus 
    {
        [EnumMember(Value = "created")]
        Created,
            
        [EnumMember(Value = "user_initiated")]
        UserInitiated,
            
        [EnumMember(Value = "user_aborted")]
        UserAborted,
            
        [EnumMember(Value = "timed_out")]
        TimedOut,
            
        [EnumMember(Value = "invalidated")]
        Invalidated,
            
        [EnumMember(Value = "failed")]
        Failed,
            
        [EnumMember(Value = "success")]
        Success,
    }
}