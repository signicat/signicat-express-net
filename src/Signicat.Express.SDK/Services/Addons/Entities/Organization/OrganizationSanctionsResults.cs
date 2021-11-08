using System.Collections.Generic;

namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationSanctionsResults
    {
        /// <summary>
        ///     List of sanction results, this list is empty of there is no hits for the organization.
        /// </summary>
        public List<SanctionResult> SanctionResults { get; set; }

        /// <summary>
        ///     Status for the sanction result
        /// </summary>
        public OrganizationSanctionsResultsStatus? Status { get; set; }

        /// <summary>
        ///     Textual description for the sanction results
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}