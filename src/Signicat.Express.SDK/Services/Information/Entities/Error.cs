using System.Collections.Generic;

namespace Signicat.Express.Information
{
    public class Error
    {
        /// <summary>
        /// A code that identifies the type of error that occured
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// A list of field specific errors
        /// </summary>
        public IEnumerable<FieldError> Errors { get; set; } = null;
    }

    public class FieldError
    {
        /// <summary>
        /// Name of attribute that was invalid
        /// </summary>
        public string Field { get; set; }
        
        /// <summary>
        /// A human-readable explanation specific to this field
        /// </summary>
        public string Message { get; set; }
    }
}