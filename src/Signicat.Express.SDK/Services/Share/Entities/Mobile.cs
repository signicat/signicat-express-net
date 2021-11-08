namespace Signicat.Express.Share
{
    public class Mobile
    {
        /// <summary>
        /// Country code, no need to add +
        /// </summary>
        public string CountryCode { get; set; }
        
        /// <summary>
        /// Valid phone number
        /// </summary>
        public string Number { get; set; }
    }
}