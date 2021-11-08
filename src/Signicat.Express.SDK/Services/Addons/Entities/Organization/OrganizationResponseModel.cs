namespace Signicat.Express.Addons.Organization
{
    public class OrganizationResponseModel
    { 
        /// <summary>
        /// Organization key information like name organization number and registeredDate
        /// </summary>
        public OrganizationInformationModel KeyInformation { get; set; }

        /// <summary>
        /// Address information for the organization
        /// </summary>
        public OrganizationAddress Address { get; set; }

        /// <summary>
        /// AML sanction result for the organization
        /// </summary>
        public OrganizationSanctionsResults Sanction { get; set; }

        /// <summary>
        /// Official roles for the organization, ceo, chair and board-members
        /// </summary>
        public OfficialRoles OfficialRoles { get; set; }

        /// <summary>
        /// Ownership for the organization, beneficial owners, shareholders and subsidiaries.
        /// </summary>
        public OrganizationOwnersModel Ownership { get; set; }

        /// <summary>
        /// List of persons that have authorization to sign for the organization
        /// </summary>
        public OrganizationAuthorizationModel Authorities { get; set; }

        /// <summary>
        /// List of persons that have authorization to sign for the organization
        /// </summary>
        public OrganizationAuthorizationModelLegacy Authorizations { get; set; }

        /// <summary>
        /// Financial information for the organizations including credit and accounting information
        /// </summary>
        public OrganizationFinancialsModel Financials { get; set; }

        /// <summary>
        /// List of links to external resources or to reports.
        /// </summary>
        public OrganizationLinksModel Links { get; set; }
    }
}
