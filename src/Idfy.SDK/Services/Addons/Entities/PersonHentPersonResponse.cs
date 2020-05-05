using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class PersonHentPersonResponse
    { 
        /// <summary>
        /// Gets or Sets Identifikasjon
        /// </summary>
        public PersonIdentifikasjon Identifikasjon { get; set; }

        /// <summary>
        /// Gets or Sets NavnAdresse
        /// </summary>
        public PersonNavnAdresse NavnAdresse { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        public PersonScoring Scoring { get; set; }

        /// <summary>
        /// Gets or Sets Delomrader
        /// </summary>
        public List<PersonDelomrader> Delomrader { get; set; }

        /// <summary>
        /// Gets or Sets BetaSammendrag
        /// </summary>
        public PersonBetaSammendrag BetaSammendrag { get; set; }

        /// <summary>
        /// Gets or Sets BetaDetaljer
        /// </summary>
        public List<PersonBetaDetaljer> BetaDetaljer { get; set; }

        /// <summary>
        /// Gets or Sets Ligning
        /// </summary>
        public List<PersonLigning> Ligning { get; set; }

        /// <summary>
        /// Gets or Sets DisponibelInntekt
        /// </summary>
        public List<PersonDisponibelInntekt> DisponibelInntekt { get; set; }

        /// <summary>
        /// Gets or Sets NaringsInteresser
        /// </summary>
        public List<PersonNaringsInteresser> NaringsInteresser { get; set; }

        /// <summary>
        /// Gets or Sets EiendomNorge
        /// </summary>
        public PersonEiendomNorge EiendomNorge { get; set; }

        /// <summary>
        /// Gets or Sets EiendomListe
        /// </summary>
        public List<PersonEiendomListe> EiendomListe { get; set; }

        /// <summary>
        /// Gets or Sets Losore
        /// </summary>
        public List<PersonLosore> Losore { get; set; }

        /// <summary>
        /// Gets or Sets TidligereNavnAdresse
        /// </summary>
        public List<PersonTidligereNavnAdresse> TidligereNavnAdresse { get; set; }

        /// <summary>
        /// Gets or Sets FullmaktForetak
        /// </summary>
        public List<PersonFullmaktForetak> FullmaktForetak { get; set; }

        /// <summary>
        /// Gets or Sets Meldinger
        /// </summary>
        public List<PersonMeldinger> Meldinger { get; set; }
    }
}
