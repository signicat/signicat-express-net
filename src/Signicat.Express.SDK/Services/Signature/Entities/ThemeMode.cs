using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum ThemeMode
    {
        [EnumMember(Value = "Default")]
        Default = 0,
    
        [EnumMember(Value = "Light")]
        Light = 1,
        
        [EnumMember(Value = "Dark")]
        Dark = 2
    }
}