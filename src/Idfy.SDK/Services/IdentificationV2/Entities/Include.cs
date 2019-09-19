using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum Include
    {
        [EnumMember(Value = "name")]
        Name = 0,
        
        [EnumMember(Value = "phone_number")]
        PhoneNumber = 1,
        
        [EnumMember(Value = "date_of_birth")]
        DateOfBirth = 2,
        
        [EnumMember(Value = "ssn")]
        Ssn = 3,
    }
}