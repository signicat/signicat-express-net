using System.Collections.Generic;

namespace Signicat.Express.Information
{
    public class ExtendedSourceInfo : SourceInfo
    {
        public bool? IsAvailable { get; set; }
        
        public int? ResponseAvg { get; set; }
    }
    
    /// <summary>
    /// Contains information about a source
    /// </summary>
    public class SourceInfo
    {
        /// <summary>
        /// The id of the source
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// The profiles supported by the source
        /// </summary>
        public IList<string> Profiles { get; set; }
        
        /// <summary>
        /// Name of the source
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Description of the source
        /// </summary>
        public string Description { get; set; }
    }
}