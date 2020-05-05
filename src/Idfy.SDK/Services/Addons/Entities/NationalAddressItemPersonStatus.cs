using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum NationalAddressItemPersonStatus
	{
        [EnumMember(Value = "RESIDENT")]
        RESIDENT,
        
        [EnumMember(Value = "RELOCATED")]
        RELOCATED,
        
        [EnumMember(Value = "EMIGRATED")]
        EMIGRATED,
        
        [EnumMember(Value = "DISAPPEARED")]
        DISAPPEARED,
        
        [EnumMember(Value = "DECEASED")]
        DECEASED,
        
        [EnumMember(Value = "SSN_EXPIRED")]
        SSNEXPIRED,
        
        [EnumMember(Value = "REGISTERED_AT_BIRTH")]
        REGISTEREDATBIRTH,
        
        [EnumMember(Value = "ANNULLED_ACCESS")]
        ANNULLEDACCESS,
        
        [EnumMember(Value = "UNREGISTERED")]
        UNREGISTERED,
        
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND,
        
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
    }
}
