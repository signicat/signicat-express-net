using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    /// <summary>
    /// The response of the Create Identitiy request
    /// </summary>
    public class CreateIdentificationResponse
    {
        /// <summary>
        /// The url to use as src for iframe or to redirect the user to.
        /// </summary>
        [JsonProperty(PropertyName = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Request ID used to get the reponse form server.
        /// afterwards
        /// </summary>
        [JsonProperty(PropertyName = "RequestId")]
        public string RequestId { get; set; }

    }
}
