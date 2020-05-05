using System;
using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonNavnAdresse
    { 
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDato
        /// </summary>
        public DateTime? StatusDato { get; set; }

        /// <summary>
        /// Gets or Sets Fodselsdato
        /// </summary>
        public DateTime? Fodselsdato { get; set; }

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
        public string Postnr { get; set; }

        /// <summary>
        /// Gets or Sets Poststed
        /// </summary>
        public string Poststed { get; set; }

        /// <summary>
        /// Gets or Sets Kommune
        /// </summary>
        public string Kommune { get; set; }

        /// <summary>
        /// Gets or Sets Fylke
        /// </summary>
        public string Fylke { get; set; }

        /// <summary>
        /// Gets or Sets Alder
        /// </summary>
        public int? Alder { get; set; }

        /// <summary>
        /// Gets or Sets Kjonn
        /// </summary>
        public string Kjonn { get; set; }

        /// <summary>
        /// Gets or Sets Telefon
        /// </summary>
        public List<string> Telefon { get; set; }
    }
}
