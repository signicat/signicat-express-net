namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationAuthorizationModelLegacy
    {
        /// <summary>
        ///     Information about the organization's signature rights.
        /// </summary>
        public OrganizationSignatureModelLegacy SignatureRights { get; set; }

        /// <summary>
        ///     Information about the organization's power of procuration rules.
        /// </summary>
        public OrganizationSignatureModelLegacy PowerOfProcuration { get; set; }

        /// <summary>
        ///     Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}