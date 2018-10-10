using System.Runtime.Serialization;

namespace Idfy.Signature
{
    public enum SignatureMechanism
    {
        [EnumMember(Value = "pkisignature")]
        PkiSignature = 0,
    
        [EnumMember(Value = "eaccept")]
        EAccept = 1,    
    }
}