using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OfficialRoles
    { 
        /// <summary>
        /// Information about the organization's CEO
        /// </summary>
        public CompanyPerson Ceo { get; set; }

        /// <summary>
        /// Information about the organization's Chairman of the board
        /// </summary>
        public CompanyPerson Chairman { get; set; }

        /// <summary>
        /// Information about the organizations deputy chairman of the board
        /// </summary>
        public CompanyPerson DeputyChairman { get; set; }

        /// <summary>
        /// Proprietor of the company
        /// </summary>
        public CompanyPerson Proprietor { get; set; }

        /// <summary>
        /// A list of the organization's Board members
        /// </summary>
        public List<CompanyPerson> BoardMembers { get; set; }

        /// <summary>
        /// A list of the organization's Deputy board members
        /// </summary>
        public List<CompanyPerson> DeputyBoardMembers { get; set; }

        /// <summary>
        /// Information about organizations contact. This role can be both a person and an organization.
        /// </summary>
        public CompanyPerson ContactPerson { get; set; }

        /// <summary>
        /// Information about organizations company secretary. This role can be both a person and an organization.
        /// </summary>
        public CompanyRolePersonAndOrganization CompanySecretary { get; set; }

        /// <summary>
        /// Information about organizations foreign representative. This role can be both a person and an organization.
        /// </summary>
        public CompanyRolePersonAndOrganization RepresentativeForeignEntity { get; set; }

        /// <summary>
        /// Information about person in the role trustee. Usually a role only filed in companies that filed for bankruptcy
        /// </summary>
        public CompanyPerson Trustee { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData MetaData { get; set; }
    }
}
