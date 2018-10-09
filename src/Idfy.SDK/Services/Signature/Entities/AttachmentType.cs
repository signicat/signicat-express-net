using System.Runtime.Serialization;

namespace Idfy
{
    public enum AttachmentType
    {
        [EnumMember(Value = "show_accept")]
        ShowAccept = 0,
    
        [EnumMember(Value = "read_accept")]
        ReadAccept = 1,
    
        [EnumMember(Value = "sign")]
        Sign = 2,
    
    }
}