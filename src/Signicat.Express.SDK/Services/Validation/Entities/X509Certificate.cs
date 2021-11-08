using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class X509Certificate
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rawData")]
        public string RawData { get; set; }
    }
}