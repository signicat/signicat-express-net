using System.Runtime.Serialization;

namespace Signicat.Express.IdentificationV2
{
    public enum ThemeMode
    {
        [EnumMember(Value = "light")]
        Light = 0,
        
        [EnumMember(Value = "dark")]
        Dark = 1,
    }
}