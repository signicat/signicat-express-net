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
        
        [EnumMember(Value = "nin")]
        Nin = 3,
        
        [EnumMember(Value = "email")]
        Email = 4,
        
        [EnumMember(Value = "resource.vipps_aml_person")]
        VippsAmlPerson = 5,
    }
}