using System.Collections.Generic;

namespace Idfy.Signature
{
    public class SignRequest 
    {
        /// <summary>
        /// Determines if you want to include the unsigned main document as an attachment to the email notification.
        /// </summary>
        public bool? IncludeOriginalFile { get; set; }
    
        /// <summary>
        /// A list of custom email texts to use for the notification. Default texts will be used if not specified.
        /// </summary>
        public List<Email> Email { get; set; }
    
        /// <summary>
        /// A list of custom SMS texts to use for the notification. Default texts will be used if not specified.
        /// </summary>
        public List<SMS> Sms { get; set; }
    }
}