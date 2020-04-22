using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Addons
{
    /// <summary>
    /// Response object for screened person
    /// </summary>
    public class PersonResponse
    {
        /// <summary>
        /// Key information
        /// </summary>
        public PersonInformation KeyInformation { get; set; }

        /// <summary>
        /// Information from ID provider
        /// </summary>
        public PersonIdInformation Identity { get; set; }

        /// <summary>
        /// Address information
        /// </summary>
        public AddressModel Address { get; set; }

        /// <summary>
        /// AML data
        /// </summary>
        public AmlModel Aml { get; set; }

        /// <summary>
        /// Links 
        /// </summary>
        public LinksModel Links { get; set; }
    }
  public class AddressModel
  {
    public NationalAddressItem National { get; set; }

    public PostalAddressItem Postal { get; set; }

    public AddressMatchStatus? MatchStatus { get; set; }

    public IEnumerable<HistoricAddressItem> Historic { get; set; }
    
    public class NationalAddressItem : ExtendedAddressItem
    {
    }
  public class BasicAddressItem
  {
    public string Address { get; set; }

    public string Address2 { get; set; }

    public string Postalcode { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    [JsonConverter(typeof (DateWithOutTimeFormater))]
    public DateTime? RegisteredDate { get; set; }

    public PersonMetaData MetaData { get; set; }
  }
  }
  public class PersonMetaData
  {
    public List<Sources> Sources { get; set; }

    public List<string> Urls { get; set; }

    public DateTime? LastChanged { get; set; }
  }
}
