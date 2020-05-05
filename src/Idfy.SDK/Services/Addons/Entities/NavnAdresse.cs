using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class NavnAdresse
    { 
        /// <summary>
        /// Gets or Sets KodeType
        /// </summary>
        public string KodeType { get; set; }

        /// <summary>
        /// Gets or Sets KodeTekst
        /// </summary>
        public string KodeTekst { get; set; }

        /// <summary>
        /// Gets or Sets Navn
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Gets or Sets Markedsnavn
        /// </summary>
        public string Markedsnavn { get; set; }

        /// <summary>
        /// Gets or Sets HistoriskNavnData
        /// </summary>
        public List<HistoriskNavnData> HistoriskNavnData { get; set; }

        /// <summary>
        /// Gets or Sets GateAdresse
        /// </summary>
        public string GateAdresse { get; set; }

        /// <summary>
        /// Gets or Sets GatePostboks
        /// </summary>
        public int? GatePostboks { get; set; }

        /// <summary>
        /// Gets or Sets GatePostnr
        /// </summary>
        public int? GatePostnr { get; set; }

        /// <summary>
        /// Gets or Sets GatePoststed
        /// </summary>
        public string GatePoststed { get; set; }

        /// <summary>
        /// Gets or Sets PostAdresse
        /// </summary>
        public string PostAdresse { get; set; }

        /// <summary>
        /// Gets or Sets PostPostboks
        /// </summary>
        public int? PostPostboks { get; set; }

        /// <summary>
        /// Gets or Sets PostPosthus
        /// </summary>
        public string PostPosthus { get; set; }

        /// <summary>
        /// Gets or Sets PostPostnr
        /// </summary>
        public int? PostPostnr { get; set; }

        /// <summary>
        /// Gets or Sets PostPoststed
        /// </summary>
        public string PostPoststed { get; set; }

        /// <summary>
        /// Gets or Sets JurAdresse
        /// </summary>
        public string JurAdresse { get; set; }

        /// <summary>
        /// Gets or Sets JurPostnr
        /// </summary>
        public int? JurPostnr { get; set; }

        /// <summary>
        /// Gets or Sets JurPoststed
        /// </summary>
        public string JurPoststed { get; set; }

        /// <summary>
        /// Gets or Sets Telefon
        /// </summary>
        public string Telefon { get; set; }

        /// <summary>
        /// Gets or Sets Telefax
        /// </summary>
        public string Telefax { get; set; }

        /// <summary>
        /// Gets or Sets Webadresse
        /// </summary>
        public string Webadresse { get; set; }

        /// <summary>
        /// Gets or Sets Epost
        /// </summary>
        public string Epost { get; set; }
    }
}
