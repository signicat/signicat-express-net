using System.Runtime.Serialization;

namespace Idfy.Notification
{
    public enum EventType
    {
        [EnumMember(Value = "document_before_deleted")]
        DocumentBeforeDeleted = 0,
    
        [EnumMember(Value = "document_canceled")]
        DocumentCanceled = 1,
    
        [EnumMember(Value = "document_created")]
        DocumentCreated = 2,
    
        [EnumMember(Value = "document_deleted")]
        DocumentDeleted = 3,
    
        [EnumMember(Value = "document_expired")]
        DocumentExpired = 4,
    
        [EnumMember(Value = "document_email_opened")]
        DocumentEmailOpened = 5,
    
        [EnumMember(Value = "document_form_partially_signed")]
        DocumentFormPartiallySigned = 6,
    
        [EnumMember(Value = "document_form_signed")]
        DocumentFormSigned = 7,
    
        [EnumMember(Value = "document_link_opened")]
        DocumentLinkOpened = 8,
    
        [EnumMember(Value = "document_packaged")]
        DocumentPackaged = 9,
    
        [EnumMember(Value = "document_partially_signed")]
        DocumentPartiallySigned = 10,
    
        [EnumMember(Value = "document_read")]
        DocumentRead = 11,
    
        [EnumMember(Value = "document_signed")]
        DocumentSigned = 12,
    
        [EnumMember(Value = "resource_created")]
        ResourceCreated = 13,
    }
}