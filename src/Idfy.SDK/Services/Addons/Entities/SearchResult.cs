using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class SearchResult
    { 
        /// <summary>
        /// Gets or Sets NextUrl
        /// </summary>
        public string NextUrl { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        public int? Start { get; set; }

        /// <summary>
        /// Gets or Sets NumFound
        /// </summary>
        public int? NumFound { get; set; }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        public int? Rows { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        public List<LeiRecord> Results { get; set; }
    }
}
