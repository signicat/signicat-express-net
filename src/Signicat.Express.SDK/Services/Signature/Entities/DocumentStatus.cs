using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum DocumentStatus
    {
        [EnumMember(Value = "unsigned")]
        Unsigned = 0,
    
        [EnumMember(Value = "waiting_for_attachments")]
        WaitingForAttachments = 1,
    
        [EnumMember(Value = "partialsigned")]
        Partialsigned = 2,
    
        [EnumMember(Value = "signed")]
        Signed = 3,
    
        [EnumMember(Value = "canceled")]
        Canceled = 4,
    
        [EnumMember(Value = "expired")]
        Expired = 5,
    }
}