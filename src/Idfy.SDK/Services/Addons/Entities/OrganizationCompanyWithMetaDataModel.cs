namespace Idfy.Addons.Entities
{
    public class OrganizationCompanyWithMetaDataModel
    { 
        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationOrganizationMetaData Metadata { get; set; }

        /// <summary>
        /// The name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The organization number
        /// </summary>
        public string OrganizationNumber { get; set; }
    }
}
