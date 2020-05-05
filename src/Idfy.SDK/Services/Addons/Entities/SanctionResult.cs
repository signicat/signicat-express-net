using System;
using System.Collections.Generic;
using Idfy.Addons.Entities.Organization;
using Idfy.Addons.Entities.Person;

namespace Idfy.Addons.Entities
{
    /// <summary>
    /// List of all Sanction items with match for the input request.
    /// </summary>
    public class SanctionResult
    { 
        /// <summary>
        /// Quality indicator of match. Higher number means better match.
        /// </summary>
        public int? MatchIndicator { get; set; }

        /// <summary>
        /// Short description of the match indicator.
        /// </summary>
        public string MatchIndicatorDescription { get; set; }

        /// <summary>
        /// May be a text string denoting title of position, job title, etc
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Additional details about what the person does
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// A comment of some kind may be present in some lists
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Name aliases for the person. May be none, one or more.
        /// </summary>
        public List<string> AliasList { get; set; }

        /// <summary>
        /// List of addresses found in the lists
        /// </summary>
        public List<AddressList> AddressList { get; set; }

        /// <summary>
        /// URLs to source documents (May be used for further investigations)
        /// </summary>
        public List<string> UrlList { get; set; }

        /// <summary>
        /// Name of data provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// The name of the source list, e.g. 'EU_GLOBAL', 'PEP_Edge', 'UN_CONSOLIDATED'
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }

        /// <summary>
        /// External identification
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Date of last update
        /// </summary>
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Date of first update
        /// </summary>
        public DateTime? FirstUpdate { get; set; }

        /// <summary>
        /// List of potential dates of birth for the person
        /// </summary>
        public List<string> BirthDateInfo { get; set; }

        /// <summary>
        /// Quality on name match, between 0.0 - 1.0. Where the higher the number, better the match
        /// </summary>
        public double? NameMatchValue { get; set; }

        /// <summary>
        /// Name of person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date of birth for the person
        /// </summary>
        public string BirthDate { get; set; }
    }
}
