using System;

namespace Idfy.Addons.Entities
{
    public class Aksjonar
    { 
        /// <summary>
        /// Gets or Sets Orgnr
        /// </summary>
        public int? Orgnr { get; set; }

        /// <summary>
        /// Gets or Sets InternRef
        /// </summary>
        public long? InternRef { get; set; }

        /// <summary>
        /// Gets or Sets FodtDato
        /// </summary>
        public DateTime? FodtDato { get; set; }

        /// <summary>
        /// Gets or Sets Navn
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Gets or Sets Postnr
        /// </summary>
        public int? Postnr { get; set; }

        /// <summary>
        /// Gets or Sets Poststed
        /// </summary>
        public string Poststed { get; set; }

        /// <summary>
        /// Gets or Sets Eierandel
        /// </summary>
        public double? Eierandel { get; set; }
    }
}
