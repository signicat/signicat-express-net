using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class Scoring
    { 
        /// <summary>
        /// Gets or Sets Beslutning
        /// </summary>
        public string Beslutning { get; set; }

        /// <summary>
        /// Gets or Sets ArsaksData
        /// </summary>
        public List<ArsaksData> ArsaksData { get; set; }

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

        /// <summary>
        /// Gets or Sets Scorevariabel
        /// </summary>
        public List<Scorevariabel> Scorevariabel { get; set; }

        /// <summary>
        /// Gets or Sets Raascore
        /// </summary>
        public int? Raascore { get; set; }

        /// <summary>
        /// Gets or Sets Risikoklasse
        /// </summary>
        public string Risikoklasse { get; set; }

        /// <summary>
        /// Gets or Sets PD
        /// </summary>
        public double? PD { get; set; }

        /// <summary>
        /// Gets or Sets Undermodell
        /// </summary>
        public string Undermodell { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        public long? Limit { get; set; }
    }
}
