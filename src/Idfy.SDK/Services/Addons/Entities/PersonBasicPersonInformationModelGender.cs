using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum PersonBasicPersonInformationModelGender
	{
        [EnumMember(Value = "Unknown")]
        Unknown,
        
        [EnumMember(Value = "Male")]
        Male,
        
        [EnumMember(Value = "Female")]
        Female,
    }
}
