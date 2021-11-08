using System;
using System.Runtime.Serialization;

namespace Idfy
{
    public enum OAuthScope
    {
        [EnumMember(Value = "addons")]
        Addons,
    
        [EnumMember(Value = "account_read")]
        AccountRead,
        
        [EnumMember(Value = "account_write")]
        AccountWrite,
        
        [EnumMember(Value = "dealer")]
        Dealer,
        
        [EnumMember(Value = "document_read")]
        DocumentRead,
        
        [EnumMember(Value = "document_write")]
        DocumentWrite,
        
        [EnumMember(Value = "document_file")]
        DocumentFile,
        
        [EnumMember(Value = "event")]
        Event,
        
        [EnumMember(Value = "jwt")]
        Jwt,
        
        [EnumMember(Value = "identify")]
        Identify,
        
        [EnumMember(Value = "merchantsign")]
        MerchantSign,
        
        [EnumMember(Value = "validation")]
        Validation,
        
        [EnumMember(Value = "validation_ssn")]
        ValidationSsn,
        
        [EnumMember(Value = "share_write")]
        ShareWrite,
        
        [EnumMember(Value = "share_read")]
        ShareRead,
        
        [EnumMember(Value = "deposit_write")]
        DepositWrite,
        
        [EnumMember(Value = "deposit_read")]
        DepositRead
    }
}