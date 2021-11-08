using System.Runtime.Serialization;

namespace Signicat.Express.IdentificationV2
{
    public enum IdSessionFlow {
        [EnumMember(Value = "redirect")]
        Redirect = 0,
            
        [EnumMember(Value = "iframe")]
        Iframe = 1,
            
        [EnumMember(Value = "headless")]
        Headless = 2,
    }
}