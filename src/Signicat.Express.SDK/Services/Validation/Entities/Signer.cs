using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class Signer
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identificator")]
        public string Identificator { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identificatorType")]
        public IdentificatorType? IdentificatorType { get; set; }
    }
}