using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Person
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
