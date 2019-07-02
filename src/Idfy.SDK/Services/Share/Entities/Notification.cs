using System.Collections.Generic;

namespace Idfy.Share.Entities
{
    /// <summary>
    /// Options for notification
    /// </summary>
    public class Notification
    {
        public NotificationSetup Setup { get; set; }
        
        /// <summary>
        /// Language for the notifications. Defaults to Norwegian
        /// </summary>
        public Language Language { get; set; }
        
        
        /// <summary>
        /// Custom texts in email notifcations 
        /// </summary>
        public Dictionary<CustomTextEvent, string> CustomEmailTexts{ get; set; }
        
     
    }
}