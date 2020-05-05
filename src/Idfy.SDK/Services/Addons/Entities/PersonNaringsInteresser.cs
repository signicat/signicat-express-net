using System;

namespace Idfy.Addons.Entities
{
    public class PersonNaringsInteresser
    { 
        /// <summary>
        /// Gets or Sets Orgnr
        /// </summary>
        public int? Orgnr { get; set; }

        /// <summary>
        /// Gets or Sets StatusKode
        /// </summary>
        public string StatusKode { get; set; }

        /// <summary>
        /// Gets or Sets StatusTekst
        /// </summary>
        public string StatusTekst { get; set; }

        /// <summary>
        /// Gets or Sets StatusDato
        /// </summary>
        public DateTime? StatusDato { get; set; }

        /// <summary>
        /// Gets or Sets Navn
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Gets or Sets SelskForm
        /// </summary>
        public string SelskForm { get; set; }

        /// <summary>
        /// Gets or Sets Rolle
        /// </summary>
        public string Rolle { get; set; }

        /// <summary>
        /// Gets or Sets Eierandel
        /// </summary>
        public double? Eierandel { get; set; }

        /// <summary>
        /// Gets or Sets VervKode
        /// </summary>
        public string VervKode { get; set; }

        /// <summary>
        /// Gets or Sets VervTekst
        /// </summary>
        public string VervTekst { get; set; }
    }
}
