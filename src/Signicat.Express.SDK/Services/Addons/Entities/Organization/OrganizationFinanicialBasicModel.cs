namespace Signicat.Express.Addons.Organization
{
    public class OrganizationFinanicialBasicModel
    {
        /// <summary>
        ///     Gets or Sets ShareCapital
        /// </summary>
        public double? ShareCapital { get; set; }

        /// <summary>
        ///     Gets or Sets TurnOver
        /// </summary>
        public double? TurnOver { get; set; }

        /// <summary>
        ///     Gets or Sets OperatingProfit
        /// </summary>
        public double? OperatingProfit { get; set; }

        /// <summary>
        ///     Gets or Sets Equity
        /// </summary>
        public double? Equity { get; set; }

        /// <summary>
        ///     Gets or Sets Earnings
        /// </summary>
        public double? Earnings { get; set; }

        /// <summary>
        ///     Gets or Sets Metadata
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}