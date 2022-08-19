using System.Runtime.Serialization;

namespace Signicat.Express.Authentication
{
    public enum ExtraInfoResourceStatus
    {
        [EnumMember(Value = "pending")]
        Pending = 0,
        
        [EnumMember(Value = "missing_credentials")]
        MissingCredentials = 1,
        
        [EnumMember(Value = "unsupported_idp")]
        UnsupportedIdp = 2,
        
        [EnumMember(Value = "not_found")]
        NotFound = 3,
        
        [EnumMember(Value = "unknown_error")]
        UnknownError = 4,
        
        [EnumMember(Value = "success")]
        Success = 5,
        
        [EnumMember(Value = "insufficient_access")]
        InsufficientAccess = 6,
        
        [EnumMember(Value = "invalid_credentials")]
        InvalidCredentials = 7,
        
        [EnumMember(Value = "service_unavailable")]
        ServiceUnavailable = 8,
    }
}
