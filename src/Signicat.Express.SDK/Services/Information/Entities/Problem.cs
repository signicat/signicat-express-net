using System.Collections.Generic;

namespace Signicat.Express.Information
{
    public class Problem
    {
        /// <summary>
        /// A code that identifies the type of error that occured
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// A URI reference that identifies the problem type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// The HTTP status code
        /// </summary>
        public int? Status { get; set; }
        
        /// <summary>
        /// A list of parameters that are invalid
        /// </summary>
        public IEnumerable<InvalidParam> InvalidParams { get; set; } = null;
    }
    
    public class InvalidParam
    {
        /// <summary>
        /// Name of attribute that was invalid
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// A human-readable explanation specific to this field
        /// </summary>
        public string Reason { get; set; }
    }
}