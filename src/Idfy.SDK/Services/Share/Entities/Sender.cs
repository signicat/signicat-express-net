namespace Idfy.Share.Entities
{
    public class Sender
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        public Mobile Mobile { get; set; }

        /// <summary>
        /// What kind of notifications does this sender want to receive, defaults to off
        /// </summary>
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// At what events does this sender want to be notified. Defaults to none 
        /// </summary>
        public NotificationEvent NotificationEvent { get; set; }
    }
}