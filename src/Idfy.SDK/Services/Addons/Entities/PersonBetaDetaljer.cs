using System;

namespace Idfy.Addons.Entities
{
    public class PersonBetaDetaljer
    { 
        /// <summary>
        /// Gets or Sets RegistrertDato
        /// </summary>
        public DateTime? RegistrertDato { get; set; }

        /// <summary>
        /// Gets or Sets BetaGruppeKode
        /// </summary>
        public string BetaGruppeKode { get; set; }

        /// <summary>
        /// Gets or Sets BetaGruppeTekst
        /// </summary>
        public string BetaGruppeTekst { get; set; }

        /// <summary>
        /// Gets or Sets BetaType
        /// </summary>
        public string BetaType { get; set; }

        /// <summary>
        /// Gets or Sets BetaTekst
        /// </summary>
        public string BetaTekst { get; set; }

        /// <summary>
        /// Gets or Sets BetaBelop
        /// </summary>
        public long? BetaBelop { get; set; }

        /// <summary>
        /// Gets or Sets KildeKode
        /// </summary>
        public string KildeKode { get; set; }

        /// <summary>
        /// Gets or Sets KildeTekst
        /// </summary>
        public string KildeTekst { get; set; }

        /// <summary>
        /// Gets or Sets KildeReferansenr
        /// </summary>
        public long? KildeReferansenr { get; set; }

        /// <summary>
        /// Gets or Sets StatusAnmerkning
        /// </summary>
        public string StatusAnmerkning { get; set; }

        /// <summary>
        /// Gets or Sets StatusDato
        /// </summary>
        public DateTime? StatusDato { get; set; }

        /// <summary>
        /// Gets or Sets Kreditor
        /// </summary>
        public string Kreditor { get; set; }
    }
}
