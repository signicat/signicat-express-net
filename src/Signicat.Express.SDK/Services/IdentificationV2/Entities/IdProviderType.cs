using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum IdProviderType 
    {
        [EnumMember(Value = "no_bankid_netcentric")]
        NoBankidNetcentric = 0,
            
        [EnumMember(Value = "no_bankid_mobile")]
        NoBankidMobile = 1,
            
        [EnumMember(Value = "se_bankid")]
        SeBankid = 2,
            
        [EnumMember(Value = "no_buypass")]
        NoBuypass = 3,
            
        [EnumMember(Value = "dk_nemid")]
        DkNemid = 4,
            
        [EnumMember(Value = "fi_eid")]
        FiEid = 5,
            
        [EnumMember(Value = "sms_otp")]
        SmsOtp = 6,
            
        [EnumMember(Value = "freja")]
        Freja = 7,
        
        [EnumMember(Value = "github")]
        GitHub = 8,
        
        [EnumMember(Value = "google")]
        Google = 9,
        
        [EnumMember(Value = "linkedin")]
        LinkedIn = 10,
        
        [EnumMember(Value = "email_otp")]
        EmailOtp = 11,

        [EnumMember(Value = "microsoft")]
        Microsoft = 12,
        
        [EnumMember(Value = "itsme")]
        Itsme = 13,
        
        [EnumMember(Value = "idin")]
        Idin = 14,
        
        [EnumMember(Value = "digid")]
        DigiD = 15,
        
        [EnumMember(Value = "eherkenning")]
        EHerkenning = 16,
        
        [EnumMember(Value = "mitid")]
        Mitid = 17,
    }
}
