using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
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
