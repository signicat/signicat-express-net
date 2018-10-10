using System.Runtime.Serialization;

namespace Idfy.MerchantSign
{
    public enum DataEncodingFormat
    {
        [EnumMember(Value = "UTF8")]
        UTF8 = 0,
        
        [EnumMember(Value = "ISOLATIN")]
        ISOLATIN = 1
    }
}