using System;

namespace Signicat.Express.Information
{
    /// <summary>
    /// Address of the entity
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Street address or PO box
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Zip code / Postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// City or place
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country codes
        /// </summary>
        public Iso3166 Country { get; set; }
    }

    public class ExtendedAddress : Address
    {
        /// <summary>
        /// Type of address
        /// </summary>
        public AddressType Type { get; set; }
        
        /// <summary>
        /// Start date of the address
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }
        
        /// <summary>
        /// End date of the address
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }
    }

    public enum AddressType
    {
        /// <summary>
        /// Unknown address
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// Address in official records
        /// </summary>
        Registered = 1,
        
        /// <summary>
        /// Principle place of business dealings and operations
        /// </summary>
        Business = 2,
        
        /// <summary>
        /// Postal address
        /// </summary>
        Postal = 3
    }
    
    public enum DatedAddressType
    {
        /// <summary>
        /// Unknown address
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// Address in official records
        /// </summary>
        Registered = 1,
        
        /// <summary>
        /// Principle place of business dealings and operations
        /// </summary>
        Business = 2,
        
        /// <summary>
        /// Postal address
        /// </summary>
        Postal = 3
    }
}