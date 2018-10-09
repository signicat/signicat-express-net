﻿using System;
using System.Collections.Generic;

namespace Idfy.Signature
{
    public class SignerOptions
    {
        /// <summary>
        /// Your reference for the signer.
        /// </summary>
        public string ExternalSignerId { get; set; }
    
        /// <summary>
        /// Return URLs and domain settings
        /// </summary>
        public RedirectSettings RedirectSettings { get; set; }
    
        /// <summary>
        /// Settings for the allowed signature methods.
        /// </summary>
        public SignatureType SignatureType { get; set; }
    
        /// <summary>
        /// Define the signers name, mobile and email if you are using notifications
        /// </summary>
        public SignerInfo SignerInfo { get; set; }
    
        /// <summary>
        /// Do you want the signer to authenticate before they can see the document?
        /// </summary>
        public Authentication Authentication { get; set; }
    
        /// <summary>
        /// Settings for extra information to collect about the signer.
        /// </summary>
        public ExtraInfoSignerRequest ExtraInfo { get; set; }
    
        /// <summary>
        /// UI settings for the signature process.
        /// </summary>
        public UI Ui { get; set; }
    
        /// <summary>
        /// Email/SMS notification settings for the signer.
        /// </summary>
        public Notifications Notifications { get; set; }
    
        /// <summary>
        /// Document tags.
        /// </summary>
        public List<string> Tags { get; set; }
    
        /// <summary>
        /// Optional order of signing for the signer.
        /// </summary>
        public int? Order { get; set; }
    
        /// <summary>
        /// Determines if the signer is required to sign the document before other signers. Any other signers will not be allowed to sign before all required signers have signed the document.
        /// </summary>
        public bool? Required { get; set; }
    
        /// <summary>
        /// The time at which the signature URL expires (ISO 8601). Specify this if you want a limited time-to-live for the URL. Defaults to the lifetime of the document.
        /// </summary>
        public DateTime? SignUrlExpires { get; set; }
    }
}