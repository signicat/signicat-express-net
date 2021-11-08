using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum AuthenticationMechanism
    {
        [EnumMember(Value = "off")]
        Off = 0,
    
        [EnumMember(Value = "eid")]
        Eid = 1,
    
        [EnumMember(Value = "smsOtp")]
        SmsOtp = 2,
    
        [EnumMember(Value = "eidAndSmsOtp")]
        EidAndSmsOtp = 3,
    }
}