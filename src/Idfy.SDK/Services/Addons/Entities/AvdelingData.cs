using System;

namespace Idfy.Addons.Entities
{
    public class AvdelingData
    { 
        /// <summary>
        /// Gets or Sets AntallAnsatte
        /// </summary>
        public int? AntallAnsatte { get; set; }

        /// <summary>
        /// Gets or Sets AntallAnsatteSpecified
        /// </summary>
        public bool? AntallAnsatteSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Telefon
        /// </summary>
        public int? Telefon { get; set; }

        /// <summary>
        /// Gets or Sets TelefonSpecified
        /// </summary>
        public bool? TelefonSpecified { get; set; }

        /// <summary>
        /// Gets or Sets Telefax
        /// </summary>
        public int? Telefax { get; set; }

        /// <summary>
        /// Gets or Sets TelefaxSpecified
        /// </summary>
        public bool? TelefaxSpecified { get; set; }

        /// <summary>
        /// Gets or Sets StiftetDato
        /// </summary>
        public DateTime? StiftetDato { get; set; }

        /// <summary>
        /// Gets or Sets BransjeKode
        /// </summary>
        public string BransjeKode { get; set; }

        /// <summary>
        /// Gets or Sets BransjeTekst
        /// </summary>
        public string BransjeTekst { get; set; }

        /// <summary>
        /// Gets or Sets DagligLeder
        /// </summary>
        public string DagligLeder { get; set; }

        /// <summary>
        /// Gets or Sets HovedforetakOrgnr
        /// </summary>
        public int? HovedforetakOrgnr { get; set; }

        /// <summary>
        /// Gets or Sets HovedforetakOrgnrSpecified
        /// </summary>
        public bool? HovedforetakOrgnrSpecified { get; set; }

        /// <summary>
        /// Gets or Sets HovedforetakDunsnr
        /// </summary>
        public int? HovedforetakDunsnr { get; set; }

        /// <summary>
        /// Gets or Sets HovedforetakDunsnrSpecified
        /// </summary>
        public bool? HovedforetakDunsnrSpecified { get; set; }

        /// <summary>
        /// Gets or Sets HovedforetakNavn
        /// </summary>
        public string HovedforetakNavn { get; set; }
    }
}
