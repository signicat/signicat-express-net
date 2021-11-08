using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum Spinner
    {
        [EnumMember(Value = "Document")]
        Document = 0,
    
        [EnumMember(Value = "Classic")]
        Classic = 1,
    
        [EnumMember(Value = "Cubes")]
        Cubes = 2,
    
        [EnumMember(Value = "Bounce")]
        Bounce = 3,
    }
}