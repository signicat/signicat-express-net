namespace Idfy.Addons.Entities
{
    public class PersonEconomy
    { 
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets NetIncome
        /// </summary>
        public double? NetIncome { get; set; }

        /// <summary>
        /// Gets or Sets IncomeChange
        /// </summary>
        public double? IncomeChange { get; set; }

        /// <summary>
        /// Gets or Sets Fortune
        /// </summary>
        public double? Fortune { get; set; }

        /// <summary>
        /// Gets or Sets AssessedTax
        /// </summary>
        public double? AssessedTax { get; set; }

        /// <summary>
        /// Gets or Sets TaxClass
        /// </summary>
        public string TaxClass { get; set; }

        /// <summary>
        /// Gets or Sets Municipal
        /// </summary>
        public string Municipal { get; set; }

        /// <summary>
        /// Gets or Sets MunicipalNumber
        /// </summary>
        public string MunicipalNumber { get; set; }
    }
}
