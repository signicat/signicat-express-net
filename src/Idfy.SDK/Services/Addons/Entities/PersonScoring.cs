using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonScoring
    { 
        /// <summary>
        /// Gets or Sets Beslutning
        /// </summary>
        public string Beslutning { get; set; }

        /// <summary>
        /// Gets or Sets ArsaksData
        /// </summary>
        public List<PersonArsaksData> ArsaksData { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// Gets or Sets GrenseAvslag
        /// </summary>
        public int? GrenseAvslag { get; set; }

        /// <summary>
        /// Gets or Sets GrenseGodkjent
        /// </summary>
        public int? GrenseGodkjent { get; set; }
    }
}
