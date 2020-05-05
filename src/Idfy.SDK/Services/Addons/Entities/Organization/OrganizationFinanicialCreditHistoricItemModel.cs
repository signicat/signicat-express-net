namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationFinanicialCreditHistoricItemModel
    {
        /// <summary>
        ///     Gets or Sets Rating
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        ///     Gets or Sets Year
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        ///     Gets or Sets Change
        /// </summary>
        public OrganizationCreditHistoryItemChangeModel Change { get; set; }
    }
}