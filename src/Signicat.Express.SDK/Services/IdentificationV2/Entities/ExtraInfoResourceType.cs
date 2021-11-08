using System.Runtime.Serialization;

namespace Signicat.Express.IdentificationV2
{
    public enum ExtraInfoResourceType
    {
        [EnumMember(Value = "vipps_aml_person")]
        VippsAmlPerson = 0,
    }
}