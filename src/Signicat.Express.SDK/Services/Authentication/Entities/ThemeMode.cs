using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum ThemeMode
    {
        [EnumMember(Value = "light")]
        Light = 0,
        
        [EnumMember(Value = "dark")]
        Dark = 1,
    }
}