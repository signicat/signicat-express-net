using System;

namespace Signicat.Express.Addons.Person
{
    public class HistoricAddressItem
    { 
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Postalcode
        /// </summary>
        public string Postalcode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredDate
        /// </summary>
        public DateTime? RegisteredDate { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        public PersonMetaData MetaData { get; set; }
    }
}
