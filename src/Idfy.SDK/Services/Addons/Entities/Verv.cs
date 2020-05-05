using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class Verv
    { 
        /// <summary>
        /// Gets or Sets InternRef
        /// </summary>
        public long? InternRef { get; set; }

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
        /// Gets or Sets Fornavn
        /// </summary>
        public string Fornavn { get; set; }

        /// <summary>
        /// Gets or Sets Mellomnavn
        /// </summary>
        public string Mellomnavn { get; set; }

        /// <summary>
        /// Gets or Sets Etternavn
        /// </summary>
        public string Etternavn { get; set; }

        /// <summary>
        /// Gets or Sets Telefon
        /// </summary>
        public List<string> Telefon { get; set; }

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
        /// Gets or Sets VervKode
        /// </summary>
        public string VervKode { get; set; }

        /// <summary>
        /// Gets or Sets VervTekst
        /// </summary>
        public string VervTekst { get; set; }

        /// <summary>
        /// Gets or Sets Landkode
        /// </summary>
        public string Landkode { get; set; }
    }
}
