using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class ReturnUrls
    {
        /// <summary>
        /// The url to be redirected to if the identification process fails.
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public string Error { get; set; }

        /// <summary>
        /// The url to be redirected to if the user aborts the identification process.
        /// </summary>
        [JsonProperty(PropertyName = "Abort")]
        public string Abort { get; set; }

        /// <summary>
        /// The return urls to be redirected to after the identification process is a success.
        /// </summary>
        [JsonProperty(PropertyName = "Success")]
        public string Success { get; set; }
    }
}
