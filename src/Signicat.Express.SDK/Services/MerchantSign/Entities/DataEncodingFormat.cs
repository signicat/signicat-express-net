using System.Runtime.Serialization;

namespace Idfy.MerchantSign
{
    public enum DataEncodingFormat
    {
        [EnumMember(Value = "UTF8")]
        Utf8 = 0,
        
        [EnumMember(Value = "ISOLATIN")]
        IsoLatin = 1
    }
}