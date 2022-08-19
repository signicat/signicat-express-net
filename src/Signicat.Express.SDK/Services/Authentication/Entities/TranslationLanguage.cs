using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
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