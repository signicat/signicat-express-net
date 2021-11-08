using System;

namespace Signicat.Express.Addons.Organization
{
    /// <summary>
    /// Other information
    /// </summary>
    public class OtherInformation
    { 
        /// <summary>
        /// If person is deceased
        /// </summary>
        public bool? Deceased { get; set; }

        /// <summary>
        /// Deceased date
        /// </summary>
        public DateTime? DeceasedDate { get; set; }
    }
}
