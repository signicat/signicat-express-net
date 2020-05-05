using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OrganizationMetaData
    { 
        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        public List<PersonMetaDataSources> Sources { get; set; }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        public List<string> Urls { get; set; }

        /// <summary>
        /// Gets or Sets AccountingYear
        /// </summary>
        public int? AccountingYear { get; set; }

        /// <summary>
        /// Gets or Sets LastChanged
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }
}
