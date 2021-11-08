using Newtonsoft.Json;

namespace Idfy.MerchantSign
{
    public class Error
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorDescription")]
        public string ErrorDescription { get; set; }
    }
}
