using System.Collections.Generic;

namespace Signicat.Express.Information
{
    public class CoverageDto
    {
        public IList<CountryCoverage> Coverage { get; set; }
    }
    
    public class CountryCoverage
    {
        public string Country { get; set; }
        
        public IList<string> Profiles { get; set; }
    }
}