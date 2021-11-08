using System.Runtime.Serialization;

namespace Idfy.Validation
{
    public enum CertificateType
    {
        [EnumMember(Value = "HSM_MERCHANT_CERTIFICATE")]
        HsmMerchantCertificate = 0,
    
        [EnumMember(Value = "MOBILE_PERSONAL_CERTIFICATE")]
        MobilePersonalCertificate = 1,
    
        [EnumMember(Value = "NETCENTRIC_EMPLOYEE_CERTIFICATE")]
        NetcentricEmployeeCertificate = 2,
    
        [EnumMember(Value = "NETCENTRIC_PERSONAL_CERTIFICATE")]
        NetcentricPersonalCertificate = 3,
    
        [EnumMember(Value = "NETCENTRIC_QUALIFIED_EMPLOYEE_CERTIFICATE")]
        NetcentricQualifiedEmployeeCertificate = 4,
    
        [EnumMember(Value = "NETCENTRIC_QUALIFIED_PERSONAL_CERTIFICATE")]
        NetcentricQualifiedPersonalCertificate = 5,
    
        [EnumMember(Value = "SOFT_MERCHANT_CERTIFICATE")]
        SoftMerchantCertificate = 6,
    
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 7,
    }
}