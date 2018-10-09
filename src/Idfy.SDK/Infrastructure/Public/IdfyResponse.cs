using System;

namespace Idfy
{
    public class IdfyResponse
    {
        public string ResponseJson { get; set; }
        
        public string RequestId { get; set; }
        
        public DateTime RequestDate { get; set; }
    }
}