using System;

namespace Idfy.Addons.Entities
{
    public class NaringsInteresserGjenpart
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
        /// Gets or Sets SelskapsFormKode
        /// </summary>
        public string SelskapsFormKode { get; set; }

        /// <summary>
        /// Gets or Sets SelskapsFormTekst
        /// </summary>
        public string SelskapsFormTekst { get; set; }

        /// <summary>
        /// Gets or Sets RolleKode
        /// </summary>
        public string RolleKode { get; set; }

        /// <summary>
        /// Gets or Sets RolleTekst
        /// </summary>
        public string RolleTekst { get; set; }

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
