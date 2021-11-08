using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class CreateBankIDMobileResponse
    {
        /// <summary>
        /// Request ID used to get the response from server afterwards.
        /// </summary>
        [JsonProperty(PropertyName = "RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// The merchant ref to show to the end user.
        /// </summary>
        [JsonProperty(PropertyName = "MerchantRef")]
        public string MerchantRef { get; set; }

        /// <summary>
        /// Information about error if the identification process failed.
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public Error Error { get; set; }

        /// <summary>
        /// Whether the request started without errors.
        /// </summary>
        [JsonProperty(PropertyName = "OK")]
        public bool? OK { get; set; }

        /// <summary>
        /// Whether  the mobile number of the date of birth was invalid.
        /// </summary>
        [JsonProperty(PropertyName = "InvalidMobileNumberOrDateOfBirth")]
        public bool? InvalidMobileNumberOrDateOfBirth { get; set; }
    }
}
