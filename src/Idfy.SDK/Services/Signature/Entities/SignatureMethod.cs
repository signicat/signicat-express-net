using System.Runtime.Serialization;

namespace Idfy.Signature
{
    public enum SignatureMethod
    {
        [EnumMember(Value = "no_bankid_mobile")]
        NoBankIdMobile = 1,
    
        [EnumMember(Value = "no_bankid_netcentric")]
        NoBankIdNetcentric = 2,
    
        [EnumMember(Value = "no_buypass")]
        NoBuypass = 3,

        [EnumMember(Value = "se_bankid")]
        SeBankid = 5,
    
        [EnumMember(Value = "dk_nemid")]
        DkNemid = 6,

        [EnumMember(Value = "sms_otp")]
        SmsOtp = 13,

        [EnumMember(Value = "unknown")]
        Unknown = 16,
        
        [EnumMember(Value = "fi_eid")]
        FiEid = 17
    }
}