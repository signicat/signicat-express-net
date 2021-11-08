using Newtonsoft.Json;

namespace Idfy.Validation
{
    public class ValidationError 
    {
        /// <summary>
        /// Null if no errors is registered
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Null if no errors is registered
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }   
    }
}