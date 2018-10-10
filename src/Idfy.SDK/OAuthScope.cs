using System.Runtime.Serialization;

namespace Idfy
{
    public enum OAuthScope
    {
        [EnumMember(Value = "document_read")]
        DocumentRead,
        
        [EnumMember(Value = "document_write")]
        DocumentWrite,
        
        [EnumMember(Value = "document_file")]
        DocumentFile,
        
        [EnumMember(Value = "event")]
        Event,
        
        [EnumMember(Value = "identify")]
        Identify,
        
        [EnumMember(Value = "validation")]
        Validation,
        
        [EnumMember(Value = "validation_ssn")]
        ValidationSsn
    }
}