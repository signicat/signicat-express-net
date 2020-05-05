using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum OrganizationSignatureModelStatus
	{
        [EnumMember(Value = "CONCLUSIVE")]
        CONCLUSIVE,
        
        [EnumMember(Value = "IN_CONCLUSIVE")]
        INCONCLUSIVE,
        
        [EnumMember(Value = "NOT_SET")]
        NOTSET,
    }
}
