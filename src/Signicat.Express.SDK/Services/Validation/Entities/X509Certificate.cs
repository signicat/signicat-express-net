using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class X509Certificate
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rawData")]
        public string RawData { get; set; }
    }
}