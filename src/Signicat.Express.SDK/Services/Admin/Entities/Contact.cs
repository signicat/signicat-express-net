using Newtonsoft.Json;

namespace Signicat.Express.Admin
{
    /// <summary>
    /// Company contact person
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }
    }
}
