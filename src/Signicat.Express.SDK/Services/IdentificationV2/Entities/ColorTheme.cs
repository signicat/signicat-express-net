using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum ColorTheme
    {
        [EnumMember(Value = "default")]
        Default = 0,
        
        [EnumMember(Value = "light_blue")]
        LightBlue = 1,
    }
}
