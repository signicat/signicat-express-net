namespace Idfy.Addons.Entities
{
    /// <summary>
    /// The organizations addresses
    /// </summary>
    public class OrganizationAddress
    { 
        /// <summary>
        /// The organizations visiting address
        /// </summary>
        public ExtendedOrganizationAddress VisitingAddress { get; set; }

        /// <summary>
        /// The organizations postal address
        /// </summary>
        public ExtendedOrganizationAddress PostalAddress { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}
