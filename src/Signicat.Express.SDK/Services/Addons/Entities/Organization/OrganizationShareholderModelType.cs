using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Organization
{
    public enum OrganizationShareholderModelType
	{
        [EnumMember(Value = "PERSON")]
        PERSON,
        
        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,
    }
}
