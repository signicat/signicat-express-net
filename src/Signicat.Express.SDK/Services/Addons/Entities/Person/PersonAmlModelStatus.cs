using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
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
