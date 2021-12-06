using Newtonsoft.Json;

namespace Signicat.Express
{
    public class ValidationError
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}