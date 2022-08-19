using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum ExtraInfoResourceType
    {
        [EnumMember(Value = "vipps_aml_person")]
        VippsAmlPerson = 0,
    }
}