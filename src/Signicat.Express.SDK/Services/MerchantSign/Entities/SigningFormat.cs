using System.Runtime.Serialization;

namespace Signicat.Express.MerchantSign
{
    public enum SigningFormat
    {
        [EnumMember(Value = "use_provider_setting")]
        UseProviderSetting = 0,
    
        [EnumMember(Value = "no_bankid_seid_sdo")]
        NoBankIdSeidSdo = 1,
    
        [EnumMember(Value = "no_bankid_pades")]
        NoBankIdPades = 2,
    
        [EnumMember(Value = "no_buypass_seid_sdo")]
        NoBuypassSeidSdo = 3,
    
        [EnumMember(Value = "da_nemid_xmldsig")]
        DaNemIdXmldsig = 4,
    
        [EnumMember(Value = "sv_bankid_native_pkcs7")]
        SvBankIdNativePkcs7 = 5,
    }
}