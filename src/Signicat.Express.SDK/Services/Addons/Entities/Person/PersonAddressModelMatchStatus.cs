using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
{
    public enum PersonAddressModelMatchStatus
	{
        [EnumMember(Value = "Equal")]
        Equal,
        
        [EnumMember(Value = "NonEqual")]
        NonEqual,
    }
}
