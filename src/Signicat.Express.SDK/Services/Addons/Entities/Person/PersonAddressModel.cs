using System.Collections.Generic;

namespace Idfy.Addons.Entities.Person
{
    /// <summary>
    /// Address information for screened person
    /// </summary>
    public class PersonAddressModel
    { 
        /// <summary>
        /// Address information from national registries
        /// </summary>
        public NationalAddressItem National { get; set; }

        /// <summary>
        /// Registered postal address
        /// </summary>
        public PostalAddressItem Postal { get; set; }

        /// <summary>
        /// Only set if both national and postal address are retrieved
        /// </summary>
        public PersonAddressModelMatchStatus? MatchStatus { get; set; }

        /// <summary>
        /// List of historic addresses
        /// </summary>
        public List<HistoricAddressItem> Historic { get; set; }
    }
}
