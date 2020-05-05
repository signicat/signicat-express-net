using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonFullmaktPerson
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
        /// Gets or Sets FullmaktTypeKode
        /// </summary>
        public string FullmaktTypeKode { get; set; }

        /// <summary>
        /// Gets or Sets FullmaktTypeTekst
        /// </summary>
        public string FullmaktTypeTekst { get; set; }

        /// <summary>
        /// Gets or Sets FullmaktKode
        /// </summary>
        public string FullmaktKode { get; set; }

        /// <summary>
        /// Gets or Sets FullmaktTekst
        /// </summary>
        public string FullmaktTekst { get; set; }

        /// <summary>
        /// Gets or Sets Prioritet
        /// </summary>
        public int? Prioritet { get; set; }

        /// <summary>
        /// Gets or Sets PrioritetSpecified
        /// </summary>
        public bool? PrioritetSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Antall
        /// </summary>
        public int? Antall { get; set; }

        /// <summary>
        /// Gets or Sets AntallSpecified
        /// </summary>
        public bool? AntallSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Obligatorisk
        /// </summary>
        public bool? Obligatorisk { get; set; }

        /// <summary>
        /// Gets or Sets ObligatoriskSpecified
        /// </summary>
        public bool? ObligatoriskSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Verv
        /// </summary>
        public List<PersonVervData> Verv { get; set; }
    }
}
