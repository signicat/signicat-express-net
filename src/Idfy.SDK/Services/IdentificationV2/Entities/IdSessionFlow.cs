using System.Runtime.Serialization;

namespace Idfy.IdentificationV2
{
    public enum IdSessionFlow {
        [EnumMember(Value = "redirect")]
        Redirect,
            
        [EnumMember(Value = "iframe")]
        Iframe,
            
        [EnumMember(Value = "headless")]
        Headless,
    }
}