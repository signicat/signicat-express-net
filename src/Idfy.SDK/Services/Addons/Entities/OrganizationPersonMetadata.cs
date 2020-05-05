using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    /// <summary>
    /// Meta data for the content, contains source information, url and other metadata.
    /// </summary>
    public class OrganizationPersonMetadata
    { 
        /// <summary>
        /// List of sources for the data
        /// </summary>
        public List<OrganizationPersonMetadataSources> Sources { get; set; }

        /// <summary>
        /// Public urls to the sources if available
        /// </summary>
        public List<string> Urls { get; set; }

        /// <summary>
        /// The date the data was last changed if available
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }
}
