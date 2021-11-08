using Newtonsoft.Json;

namespace Signicat.Express.Validation
{
    public class ValidatedSigner
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identificator")]
        public string Identificator { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identificatorType")]
        public IdentificatorType? IdentificatorType { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool? Valid { get; set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}