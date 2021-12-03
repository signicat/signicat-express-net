namespace Signicat.Express.Information.Organization
{
    public class AddressInfo
    {
        /// <summary>
        /// Business address for the organization
        /// </summary>
        public Address Business { get; set; }
        
        /// <summary>
        /// Postal address for the organization
        /// </summary>
        public Address Postal { get; set; }
        
        /// <summary>
        /// Metadata for the content
        /// </summary>
        public OrganizationMetadata Metadata { get; set; }
    }
}