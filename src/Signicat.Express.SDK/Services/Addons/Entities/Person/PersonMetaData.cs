using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities.Person
{
    public class PersonMetaData
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
        /// Gets or Sets LastChanged
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }
}
