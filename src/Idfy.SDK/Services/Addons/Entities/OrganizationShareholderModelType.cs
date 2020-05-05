using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum OrganizationShareholderModelType
	{
        [EnumMember(Value = "PERSON")]
        PERSON,
        
        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,
    }
}
