using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Idfy.Addons
{
    /// <summary>
    /// Common query input for Person query search
    /// </summary>
    public class PersonOptions
    {
        /// <summary>
        /// Date of birth, format YYYYMMDD.
        /// National ID number or date of birth is required
        /// </summary>
        public string dateOfBirth { get; set; }

        /// <summary>
        /// Person firstname
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Person lastname
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Social security number
        /// </summary>
        public string ssn { get; set; }

        /// <summary>
        /// Nationality of subject. Two letters (ISO 3166)
        /// Currently only supports NO for norway
        /// </summary>
        public string countryOfSSn { get; set; }

        /// <summary>
        /// Language of report 
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Expands to fetch info 
        /// </summary>
        public List<PersonExpand> Expands { get; set; }

        /// <summary>
        ///  MatchMode for sanction/pep search
        /// </summary>
        public MatchMode MatchMode { get; set; }

        /// <summary>
        /// Add extra information to reports
        /// </summary>
        public bool AddPdfAppendix { get; set; }
    }
}