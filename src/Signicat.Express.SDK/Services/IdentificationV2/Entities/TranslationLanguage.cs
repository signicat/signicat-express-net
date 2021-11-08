using System.Runtime.Serialization;

namespace Signicat.Express.IdentificationV2
{
    public enum TranslationLanguage {
        [EnumMember(Value = "en")]
        En,
            
        [EnumMember(Value = "no")]
        No,
            
        [EnumMember(Value = "none")]
        None,
    }
}