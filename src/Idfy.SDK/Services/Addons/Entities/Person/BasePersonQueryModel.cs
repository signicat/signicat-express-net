using System.Collections.Generic;

namespace Idfy.Addons.Entities.Person
{
    public class BasePersonQueryModel
    {
        /// <summary>
        ///     Origin country for the ssn (two letters ISO 3166 ) for now only NO for Norway is supported. When using ssn this is
        ///     required.
        /// </summary>
        public string CountryOfSsn { get; set; }

        /// <summary>
        ///     Language of the report (two letters ISO 639-1)
        /// </summary>
        public string Language { get; set; }

//        [EnumDataType(typeof(PersonExpand))]
        public List<PersonExpand> Expands { get; set; }

        /// <summary>
        ///     Match mode on name. Fuzzy mode gives matches on names that are not completely similar. Default mode exact.
        /// </summary>
        //        [EnumDataType(typeof(MatchMode))]
        public MatchMode MatchMode { get; set; }

        /// <summary>
        ///     Add extra attachment with descriptions to report. Defaults to false
        /// </summary>
        public bool AddPdfAppendix { get; set; } = false;
    }
}