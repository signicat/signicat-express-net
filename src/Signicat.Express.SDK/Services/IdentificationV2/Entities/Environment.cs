namespace Signicat.Express.IdentificationV2
{
    /// <summary>
    /// Details about the user's environment.
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// The user agent of the user's browser.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// The user's IP address.
        /// </summary>
        public string IpAddress { get; set; }
    }
}
