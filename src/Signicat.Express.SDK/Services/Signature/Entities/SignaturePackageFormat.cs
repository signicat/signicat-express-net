﻿using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum SignaturePackageFormat
    {
        [EnumMember(Value = "xades")]
        Xades = 0,
    
        [EnumMember(Value = "pades")]
        Pades = 1,
    
        [EnumMember(Value = "no_bankid_pades")]
        NoBankIdPades = 2,
    }
}