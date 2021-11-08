using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class IdentificationCompleteResponse
    {
        /// <summary>
        /// Whether the idenfication process is done.
        /// </summary>
        [JsonProperty(PropertyName = "Done")]
        public bool? Done { get; set; }
    }
}
