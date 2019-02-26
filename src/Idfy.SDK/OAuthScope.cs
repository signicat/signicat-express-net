﻿using System;
using System.Runtime.Serialization;

namespace Idfy
{
    public enum OAuthScope
    {
        [EnumMember(Value = "account_read")]
        AccountRead,
        
        [EnumMember(Value = "account_write")]
        AccountWrite,
        
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
        
        [EnumMember(Value = "merchantsign")]
        MerchantSign,
        
        [EnumMember(Value = "validation")]
        Validation,
        
        [EnumMember(Value = "validation_ssn")]
        ValidationSsn,
        
        [EnumMember(Value = "share_write")]
        ShareWrite,
        
        [EnumMember(Value = "share_read")]
        ShareRead
    }
}