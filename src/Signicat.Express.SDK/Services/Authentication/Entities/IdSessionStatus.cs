using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum IdSessionStatus 
    {
        [EnumMember(Value = "created")]
        Created = 0,
            
        [EnumMember(Value = "user_initiated")]
        UserInitiated = 1,
            
        [EnumMember(Value = "user_aborted")]
        UserAborted = 2,
            
        [EnumMember(Value = "timed_out")]
        TimedOut = 3,
            
        [EnumMember(Value = "invalidated")]
        Invalidated = 4,
            
        [EnumMember(Value = "failed")]
        Failed = 5,
            
        [EnumMember(Value = "success")]
        Success = 6,
    }
}