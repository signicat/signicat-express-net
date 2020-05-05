namespace Idfy.Addons.Entities
{
    public class OrganizationOrganizationFinancialsModel
    { 
        /// <summary>
        /// Gets or Sets KeyFigures
        /// </summary>
        public OrganizationOrganizationFinanicialBasicModel KeyFigures { get; set; }

        /// <summary>
        /// The name and organization number for the organizations auditor
        /// </summary>
        public OrganizationCompanyWithMetaDataModel Auditor { get; set; }

        /// <summary>
        /// The name and organization number for the organizations accountant
        /// </summary>
        public OrganizationCompanyWithMetaDataModel Accountant { get; set; }

        /// <summary>
        /// Credit information including rating and historic data for the organization
        /// </summary>
        public OrganizationOrganizationFinanicialCreditModel Credit { get; set; }

        /// <summary>
        /// Accounting information for the organization going back maximum 3 years
        /// </summary>
        public OrganizationAccountingModel Accounting { get; set; }
    }
}
