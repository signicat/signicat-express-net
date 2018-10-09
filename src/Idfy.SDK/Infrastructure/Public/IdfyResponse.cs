using System;

namespace Idfy
{
    public class IdfyResponse
    {
        /// <summary>
        /// The raw JSON returned by Idfy.
        /// </summary>
        public string ResponseJson { get; set; }
        
        /// <summary>
        /// A unique identifier associated with the request. You will be able to use this to search the logs in the Idfy dashboard.
        /// If you need to contact us about a specific request, providing the request identifier will ensure the fastest possible resolution.
        /// </summary>
        public string RequestId { get; set; }
        
        /// <summary>
        /// The date and time at which the request was made.
        /// </summary>
        public DateTime RequestDate { get; set; }
    }
}