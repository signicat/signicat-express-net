using System.Collections.Generic;
using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class CreateBankIDMobileRequest
    {
        /// <summary>
        /// Mobile number for the user that is to be identified.
        /// </summary>
        [JsonProperty(PropertyName = "MobileNumber")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Date of birth for the user that is to be identified.
        /// </summary>
        [JsonProperty(PropertyName = "DateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Whether the social security number should be fetched from the identity provider.
        /// </summary>
        [JsonProperty(PropertyName = "GetSocialSecurityNumber")]
        public bool? GetSocialSecurityNumber { get; set; }

        /// <summary>
        /// The merchants reference to the identification process.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// List of addon data that can be orderd. The result will be in MetaData list of the reponse.
        /// </summary>
        [JsonProperty(PropertyName = "Addonservices")]
        public IDictionary<string, string> Addonservices { get; set; }
    }
}
