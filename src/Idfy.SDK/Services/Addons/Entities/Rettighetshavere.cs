using System;

namespace Idfy.Addons.Entities
{
    public class Rettighetshavere
    { 
        /// <summary>
        /// Gets or Sets Internreferanse
        /// </summary>
        public long? Internreferanse { get; set; }

        /// <summary>
        /// Gets or Sets FodtDato
        /// </summary>
        public DateTime? FodtDato { get; set; }

        /// <summary>
        /// Gets or Sets FodtDatoSpecified
        /// </summary>
        public bool? FodtDatoSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Navn
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Gets or Sets Adresse
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Gets or Sets Postnr
        /// </summary>
        public int? Postnr { get; set; }

        /// <summary>
        /// Gets or Sets Poststed
        /// </summary>
        public string Poststed { get; set; }

        /// <summary>
        /// Gets or Sets Andel
        /// </summary>
        public double? Andel { get; set; }

        /// <summary>
        /// Gets or Sets IndirekteEier
        /// </summary>
        public bool? IndirekteEier { get; set; }

        /// <summary>
        /// Gets or Sets Landkode
        /// </summary>
        public string Landkode { get; set; }
    }
}
