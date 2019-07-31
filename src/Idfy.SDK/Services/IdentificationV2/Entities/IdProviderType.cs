using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum IdProviderType 
    {
        [EnumMember(Value = "no_bankid_netcentric")]
        NoBankidNetcentric,
            
        [EnumMember(Value = "no_bankid_mobile")]
        NoBankidMobile,
            
        [EnumMember(Value = "se_bankid")]
        SeBankid,
            
        [EnumMember(Value = "no_buypass")]
        NoBuypass,
            
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
            
        [EnumMember(Value = "fi_eid")]
        FiEid,
            
        [EnumMember(Value = "sms_otp")]
        SmsOtp,
            
        [EnumMember(Value = "freja")]
        Freja,
    }
}