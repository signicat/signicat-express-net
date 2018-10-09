using System.Collections.Generic;

namespace Idfy.Signature
{
    public class Reminder 
    {
        /// <summary>
        /// Defines a chron expression that control the interval of the reminders (Use UTC time). We use Quartz cron expressions, read more about it here: http://www.quartz-scheduler.org/documentation/quartz-2.x/tutorials/crontrigger.html.
        /// </summary>
        public string ChronSchedule { get; set; }
    
        /// <summary>
        /// The maximum number of reminders to be sent for each signer.
        /// </summary>
        public int? MaxReminders { get; set; }
    
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