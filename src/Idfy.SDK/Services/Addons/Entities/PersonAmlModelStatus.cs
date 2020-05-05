using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum PersonAmlModelStatus
	{
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        
        [EnumMember(Value = "PEP")]
        PEP,
        
        [EnumMember(Value = "SANCTION")]
        SANCTION,
        
        [EnumMember(Value = "PEP_AND_SANCTION")]
        PEPANDSANCTION,
        
        [EnumMember(Value = "NONE")]
        NONE,
    }
}
