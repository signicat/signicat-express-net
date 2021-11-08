using System.Runtime.Serialization;

namespace Signicat.Express.MerchantSign
{
    public enum DataFormat
    {
        [EnumMember(Value = "xml")]
        Xml = 0,
    
        [EnumMember(Value = "pdf")]
        Pdf = 1,
    
        [EnumMember(Value = "txt")]
        Txt = 2,
    }
}