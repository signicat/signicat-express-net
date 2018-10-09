using System.Collections.Generic;

namespace Idfy.Signature
{
    public class FinalReceipt
    {
        /// <summary>
        /// Determines if you want to include the signed main document as an attachment to the email notification. Not recommended for sensitive documents.
        /// </summary>
        public bool? IncludeSignedFile { get; set; }
    
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