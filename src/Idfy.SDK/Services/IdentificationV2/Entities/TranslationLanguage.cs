using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
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