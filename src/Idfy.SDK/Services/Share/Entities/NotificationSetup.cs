namespace Idfy.Share.Entities
{
    /// <summary>
    /// Setup of notifications
    /// </summary>
    public class NotificationSetup
    {
        /// <summary>
        /// What form of notification for creation. 
        /// Defaults to off
        /// </summary>
        public NotificationType Request { get; set; }
        /// <summary>
        /// What form of notification for reminder. 
        /// Defaults to off
        /// </summary>
        public NotificationType Reminder { get; set; }
    }
}