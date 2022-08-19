namespace Signicat.Express.Authentication
{
    /// <summary>
    /// Information about the organization the user represents.
    /// </summary>

    public class Organization
    {
        /// <summary>
        /// Organization name.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Organization number.
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// ISO 3166-1 country code.
        /// </summary>
        public string Country { get; set; }

    }
}