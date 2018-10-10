using Newtonsoft.Json;

namespace Idfy.Identification
{
    public class InvalidateIdentificationRequest
    {
        /// <summary>
        /// The request ID of the identification session.
        /// </summary>
        [JsonProperty(PropertyName = "RequestId")]
        public string RequestId { get; set; }
    }
}
