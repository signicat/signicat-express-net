using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum OrganizationSanctionsResultsStatus
	{
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        
        [EnumMember(Value = "SANCTION")]
        SANCTION,
        
        [EnumMember(Value = "NONE")]
        NONE,
    }
}
