using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
{
    public enum PersonMetaDataSources
	{
        [EnumMember(Value = "BISNODE")]
        BISNODE,
        
        [EnumMember(Value = "BRREG")]
        BRREG,
        
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
        
        [EnumMember(Value = "GLEIF")]
        GLEIF,
        
        [EnumMember(Value = "NO_NATIONAL_REGISTRY")]
        NONATIONALREGISTRY,
    }
}
