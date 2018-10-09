using System.Runtime.Serialization;

namespace Idfy.Signature
{
    public enum SignatureMethod
    {
        [EnumMember(Value = "no_bankid")]
        NoBankId = 0,
    
        [EnumMember(Value = "no_bankid_mobile")]
        NoBankIdMobile = 1,
    
        [EnumMember(Value = "no_bankid_netcentric")]
        NoBankIdNetcentric = 2,
    
        [EnumMember(Value = "no_buypass")]
        NoBuypass = 3,
    
        [EnumMember(Value = "no_commfides")]
        NoCommfides = 4,
    
        [EnumMember(Value = "se_bankid")]
        SeBankid = 5,
    
        [EnumMember(Value = "dk_nemid")]
        DkNemid = 6,
    
        [EnumMember(Value = "fi_tupas")]
        FiTupas = 7,
    
        [EnumMember(Value = "fi_mobiilivarmenne")]
        FiMobiilivarmenne = 8,
    
        [EnumMember(Value = "nl_digid")]
        NlDigid = 9,
    
        [EnumMember(Value = "es_dni")]
        EsDni = 10,
    
        [EnumMember(Value = "ee_esteid")]
        EeEsteid = 11,
    
        [EnumMember(Value = "mobile_connect")]
        MobileConnect = 12,
    
        [EnumMember(Value = "sms_otp")]
        SmsOtp = 13,
    
        [EnumMember(Value = "identification_papers")]
        IdentificationPapers = 14,
    
        [EnumMember(Value = "social")]
        Social = 15,
    
        [EnumMember(Value = "unknown")]
        Unknown = 16,
    }
}