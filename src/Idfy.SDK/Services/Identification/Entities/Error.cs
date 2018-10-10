using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class Error
    {
        /// <summary>
        /// The error code from the identity provider.
        /// </summary>
        [JsonProperty(PropertyName = "NativeErrorCode")]
        public string NativeErrorCode { get; set; }

        /// <summary>
        /// The error code for the error.
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}
