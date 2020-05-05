namespace Idfy.Addons.Entities
{
    /// <summary>
    /// Address
    /// </summary>
    public class Address
    { 
        /// <summary>
        /// Street address and number
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Postal city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country code (ISO 3166)
        /// </summary>
        public string Country { get; set; }
    }
}
