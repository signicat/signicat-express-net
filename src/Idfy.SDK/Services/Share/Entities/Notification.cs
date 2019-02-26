namespace Idfy.Share.Entities
{
    /// <summary>
    /// Options for notification
    /// </summary>
    public class Notification
    {
        public NotificationSetup Setup { get; set; }
        /// <summary>
        /// Language for the notifications
        /// Defaults to Norwegian
        /// </summary>
        public Language Language { get; set; }
    }
}