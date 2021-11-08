namespace Signicat.Express.Addons.Organization
{
    public class OrganizationBalanceSheetModel
    {
        /// <summary>
        ///     Gets or Sets CurrentAssets
        /// </summary>
        public double? CurrentAssets { get; set; }

        /// <summary>
        ///     Gets or Sets FixedAssets
        /// </summary>
        public double? FixedAssets { get; set; }

        /// <summary>
        ///     Gets or Sets SumAssets
        /// </summary>
        public double? SumAssets { get; set; }

        /// <summary>
        ///     Gets or Sets Equity
        /// </summary>
        public double? Equity { get; set; }

        /// <summary>
        ///     Gets or Sets Debt
        /// </summary>
        public double? Debt { get; set; }

        /// <summary>
        ///     Gets or Sets SumEquityAndDebt
        /// </summary>
        public double? SumEquityAndDebt { get; set; }
    }
}