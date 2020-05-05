namespace Idfy.Addons.Entities
{
    public class OrganizationOrganizationAuthorizationModel
    { 
        /// <summary>
        /// Information about the organization's signature rights.
        /// </summary>
        public OrganizationSignatureModel SignatureRights { get; set; }

        /// <summary>
        /// Information about the organization's power of procuration rules.
        /// </summary>
        public OrganizationSignatureModel PowerOfProcuration { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationOrganizationMetaData Metadata { get; set; }
    }
}
