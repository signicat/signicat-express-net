namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationFinancialsModel
    {
        /// <summary>
        ///     Gets or Sets KeyFigures
        /// </summary>
        public OrganizationFinanicialBasicModel KeyFigures { get; set; }

        /// <summary>
        ///     The name and organization number for the organizations auditor
        /// </summary>
        public OrganizationCompanyWithMetaDataModel Auditor { get; set; }

        /// <summary>
        ///     The name and organization number for the organizations accountant
        /// </summary>
        public OrganizationCompanyWithMetaDataModel Accountant { get; set; }

        /// <summary>
        ///     Credit information including rating and historic data for the organization
        /// </summary>
        public OrganizationFinanicialCreditModel Credit { get; set; }

        /// <summary>
        ///     Accounting information for the organization going back maximum 3 years
        /// </summary>
        public OrganizationAccountingModel Accounting { get; set; }
    }
}