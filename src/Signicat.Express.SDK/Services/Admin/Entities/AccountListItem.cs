using System;
using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class AccountListItem
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrgNo")]
        public string OrgNo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniCustomerNo")]
        public string UniCustomerNo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DealerId")]
        public string DealerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DealerName")]
        public string DealerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DealerReference")]
        public string DealerReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }
    }
}
