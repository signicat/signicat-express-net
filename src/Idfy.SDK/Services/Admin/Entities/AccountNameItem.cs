using System;
using Newtonsoft.Json;

namespace Idfy.Admin
{
    public class AccountNameItem
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
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }
    }
}
