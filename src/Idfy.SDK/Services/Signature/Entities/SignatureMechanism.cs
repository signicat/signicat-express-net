using System.Runtime.Serialization;

namespace Idfy.Signature
{
    public enum SignatureMechanism
    {
        [EnumMember(Value = "pkisignature")]
        Pkisignature = 0,
    
        [EnumMember(Value = "eaccept")]
        Eaccept = 1,    
    }
}