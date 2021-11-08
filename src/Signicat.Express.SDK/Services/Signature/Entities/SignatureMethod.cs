using System.Runtime.Serialization;

namespace Signicat.Express.Signature
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
        
        [EnumMember(Value = "se_bankid")]
        SeBankid = 5,
    
        [EnumMember(Value = "dk_nemid")]
        DkNemid = 6,

        [EnumMember(Value = "sms_otp")]
        SmsOtp = 13,

        [EnumMember(Value = "unknown")]
        Unknown = 16,
        
        [EnumMember(Value = "fi_eid")]
        FiEid = 17,
        
        [EnumMember(Value = "itsme")]
        Itsme = 18,

        [EnumMember(Value = "idin")]
        Idin = 19,

        [EnumMember(Value = "digid")]
        DigiD = 20,

        [EnumMember(Value = "eherkenning")]
        EHerkenning = 21,
        
        [EnumMember(Value = "mitid")]
        Mitid = 22,
    }
}