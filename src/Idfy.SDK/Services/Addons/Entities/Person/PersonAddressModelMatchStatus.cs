using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Person
{
    public enum PersonAddressModelMatchStatus
	{
        [EnumMember(Value = "Equal")]
        Equal,
        
        [EnumMember(Value = "NonEqual")]
        NonEqual,
    }
}
