using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum FileType
    {
        [EnumMember(Value = "pdf")]
        Pdf = 0,
        
        [EnumMember(Value = "txt")]
        Txt = 1,
        
        [EnumMember(Value = "xml")]
        Xml = 2
    }
}