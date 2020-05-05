using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OrganizationOrganizationOwnersModel
    { 
        /// <summary>
        /// List beneficial owners of the organization. When the ownership structure of an entity indicates that there are no beneficial owners, this list will be empty.
        /// </summary>
        public List<BeneficialOwner> Beneficial { get; set; }

        /// <summary>
        /// The list of the organization share holders
        /// </summary>
        public List<OrganizationShareholderModel> Shareholders { get; set; }

        /// <summary>
        /// The organizations subsidiaries, this list is empty the organization does not have any subsidiaries.
        /// </summary>
        public List<OrganizationCompanyOwnerShipModel> Subsidiaries { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationOrganizationMetaData Metadata { get; set; }
    }
}
