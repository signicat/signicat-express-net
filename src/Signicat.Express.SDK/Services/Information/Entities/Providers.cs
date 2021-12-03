using System.Collections.Generic;

namespace Signicat.Express.Information
{
    public class Source
    {
        public string Name { get; set; }
        
        public List<string> Profiles { get; set; }
        
        public List<string> Countries { get; set; }
    }

    public class OrgLookupProviders
    {
        /// <summary>
        /// Contains information about providers that provide organizational lookups
        /// </summary>
        public Dictionary<string, List<SourceInfo>> Providers { get; set; }

        /// <summary>
        /// Contains the different profiles for organizational lookups
        /// </summary>
        public IList<string> Profiles { get; set; }
    }
    
    public class PersonLookupProviders
    {
        /// <summary>
        /// Contains information about providers that provide person lookups
        /// </summary>
        public Dictionary<string, List<SourceInfo>> Providers { get; set; }
        
        /// <summary>
        /// Contains the different profiles for person lookups
        /// </summary>
        public IList<string> Profiles { get; set; }
    }
}