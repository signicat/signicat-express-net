using System.Runtime.Serialization;

namespace Idfy.Signature
{
    public enum ExtraInfoSignerType
    {
        [EnumMember(Value = "personalInfo")]
        PersonalInfo = 0,
    
        [EnumMember(Value = "companyInfo")]
        CompanyInfo = 1,
    
        [EnumMember(Value = "companyInfoAutoComplete")]
        CompanyInfoAutoComplete = 2,
    
        [EnumMember(Value = "personalCreditCheck")]
        PersonalCreditCheck = 3,
    
        [EnumMember(Value = "businessCreditCheck")]
        BusinessCreditCheck = 4,
    
        [EnumMember(Value = "officialPersonalInfo")]
        OfficialPersonalInfo = 5,
    
        [EnumMember(Value = "bankIDApisAmlPersonSanctionPep")]
        BankIDApisAmlPersonSanctionPep = 6,
    
        [EnumMember(Value = "bankIDApisAmlCurrentAddress")]
        BankIDApisAmlCurrentAddress = 7
    }
}