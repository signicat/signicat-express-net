using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Organization
{
    public enum OrganizationShareholderModelType
	{
        [EnumMember(Value = "PERSON")]
        PERSON,
        
        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,
    }
}
