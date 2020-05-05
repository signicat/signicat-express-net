using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonFullmaktForetak
    { 
        /// <summary>
        /// Gets or Sets Dunsnr
        /// </summary>
        public int? Dunsnr { get; set; }

        /// <summary>
        /// Gets or Sets Orgnr
        /// </summary>
        public int? Orgnr { get; set; }

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
        /// Gets or Sets StatusKode
        /// </summary>
        public string StatusKode { get; set; }

        /// <summary>
        /// Gets or Sets StatusTekst
        /// </summary>
        public string StatusTekst { get; set; }

        /// <summary>
        /// Gets or Sets Selskapsform
        /// </summary>
        public string Selskapsform { get; set; }

        /// <summary>
        /// Gets or Sets ProkuraKode
        /// </summary>
        public string ProkuraKode { get; set; }

        /// <summary>
        /// Gets or Sets ProkuraTekst
        /// </summary>
        public string ProkuraTekst { get; set; }

        /// <summary>
        /// Gets or Sets SignaturKode
        /// </summary>
        public string SignaturKode { get; set; }

        /// <summary>
        /// Gets or Sets SignaturTekst
        /// </summary>
        public string SignaturTekst { get; set; }

        /// <summary>
        /// Gets or Sets FullmaktPerson
        /// </summary>
        public List<PersonFullmaktPerson> FullmaktPerson { get; set; }
    }
}
