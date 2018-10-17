using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class AccountCreateOptions
    {
        /// <summary>
        /// Name of the account owner (company)
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Organization number
        /// </summary>
        [JsonProperty(PropertyName = "MvaNumber")]
        public string MvaNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompanyPhone")]
        public string CompanyPhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompanyEmail")]
        public string CompanyEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompanyUrl")]
        public string CompanyUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public Address Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Dealer")]
        public DealerInfo Dealer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Settings")]
        public Settings Settings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }
    }
}
