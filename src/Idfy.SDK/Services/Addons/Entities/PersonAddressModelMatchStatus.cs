using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum PersonAddressModelMatchStatus
	{
        [EnumMember(Value = "Equal")]
        Equal,
        
        [EnumMember(Value = "NonEqual")]
        NonEqual,
    }
}
