using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Person
{
    public enum PersonAmlModelList
	{
        [EnumMember(Value = "UN_CONSOLIDATED")]
        UNCONSOLIDATED,
        
        [EnumMember(Value = "EU_GLOBAL")]
        EUGLOBAL,
        
        [EnumMember(Value = "HMTREASURY")]
        HMTREASURY,
        
        [EnumMember(Value = "OFAC")]
        OFAC,
        
        [EnumMember(Value = "PEP_AC")]
        PEPAC,
        
        [EnumMember(Value = "PEP_EDGE")]
        PEPEDGE,
    }
}
