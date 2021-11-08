using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum ExtraInfoSignerType
    {
        [EnumMember(Value = "bankIDApisAmlPersonSanctionPep")]
        BankIDApisAmlPersonSanctionPep = 6,
    
        [EnumMember(Value = "bankIDApisAmlCurrentAddress")]
        BankIDApisAmlCurrentAddress = 7,
        
        [EnumMember(Value = "bankIDApisAmlPersonSanctionPepReport")]
        BankIDApisAmlPersonSanctionPepReport = 8, 
        
        [EnumMember(Value = "vippsAmlPerson")]
        VippsAmlPerson = 8,
    }
}