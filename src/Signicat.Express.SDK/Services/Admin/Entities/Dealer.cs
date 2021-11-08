using System;
using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    public class Dealer
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerNumber")]
        public int CustomerNumber { get; set; }

        /// <summary>
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
        [JsonProperty(PropertyName = "Onboarding")]
        public Onboarding Onboarding { get; set; }
    }
}
