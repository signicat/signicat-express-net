using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum ThemeMode
    {
        [EnumMember(Value = "light")]
        Light = 0,
        
        [EnumMember(Value = "dark")]
        Dark = 1,
    }
}