using System;
using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class Transaction
    {
        /// <summary>
        /// Transaction ID
        /// </summary>
        [JsonProperty(PropertyName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// The date for the transaction
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Product ID
        /// </summary>
        [JsonProperty(PropertyName = "ProductID")]
        public string ProductId { get; set; }

        /// <summary>
        /// Transaction description
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Number of transactions for the selected date
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

        /// <summary>
        /// Your customer number in our invocing system
        /// </summary>
        [JsonProperty(PropertyName = "CustomerNumber")]
        public int? CustomerNumber { get; set; }

        /// <summary>
        /// Your reference to the transaction (by ExternalRef in the API call)
        /// </summary>
        [JsonProperty(PropertyName = "ExternalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The Departments ID if specified
        /// </summary>
        [JsonProperty(PropertyName = "DepartmentId")]
        public string DepartmentId { get; set; }
    }
}
