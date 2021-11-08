using System.Runtime.Serialization;

namespace Signicat.Express.MerchantSign
{
    public enum DataEncodingFormat
    {
        [EnumMember(Value = "UTF8")]
        Utf8 = 0,
        
        [EnumMember(Value = "ISOLATIN")]
        IsoLatin = 1
    }
}