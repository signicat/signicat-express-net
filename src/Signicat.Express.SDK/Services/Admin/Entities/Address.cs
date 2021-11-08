using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class Address
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }
    }
}
