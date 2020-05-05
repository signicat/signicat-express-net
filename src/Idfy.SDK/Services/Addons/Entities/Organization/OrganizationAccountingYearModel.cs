namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationAccountingYearModel
    {
        /// <summary>
        ///     Gets or Sets Year
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        ///     Gets or Sets IncomeStatement
        /// </summary>
        public OrganizationIncomeStatementModel IncomeStatement { get; set; }

        /// <summary>
        ///     Gets or Sets BalanceSheet
        /// </summary>
        public OrganizationBalanceSheetModel BalanceSheet { get; set; }
    }
}