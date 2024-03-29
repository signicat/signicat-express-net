using System.Runtime.Serialization;

namespace Signicat.Express.Notification
{
    public enum DeliveryLogging
    {
        [EnumMember(Value = "never")]
        Never = 0,
        
        [EnumMember(Value = "failed")]
        Failed = 1,
        
        [EnumMember(Value = "always")]
        Always = 2
    }
}