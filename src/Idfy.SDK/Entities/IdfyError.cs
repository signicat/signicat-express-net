using Newtonsoft.Json;

namespace Idfy
{
    public class IdfyError
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        
        [JsonProperty("code")]
        public string Code { get; set; }
        
        // OAuth 2 errors
        [JsonProperty("error")]
        public string Error { get; set; }
        
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}