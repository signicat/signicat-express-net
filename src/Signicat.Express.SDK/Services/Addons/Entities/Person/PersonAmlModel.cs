using System.Collections.Generic;

namespace Signicat.Express.Addons.Person
{
    /// <summary>
    /// AML information about screened person
    /// </summary>
    public class PersonAmlModel
    { 
        /// <summary>
        /// List of all Sanction items with match for the input request.
        /// </summary>
        public List<SanctionResult> SanctionResults { get; set; }

        /// <summary>
        /// List of all PEP items with match for the input request.
        /// </summary>
        public List<PepResult> PepResults { get; set; }

        /// <summary>
        /// Status for the screened person, is the person pep, sanction, pep and sanction or none.
        /// </summary>
        public PersonAmlModelStatus? Status { get; set; }

        /// <summary>
        /// Response message could for example be: No result from PEP and/or SANCTION screening.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// List that have bee queried
        /// </summary>
        public List<PersonAmlModelList> List { get; set; }

        /// <summary>
        /// Sources and other information
        /// </summary>
        public OrganizationPersonMetadata Metadata { get; set; }
    }
}
