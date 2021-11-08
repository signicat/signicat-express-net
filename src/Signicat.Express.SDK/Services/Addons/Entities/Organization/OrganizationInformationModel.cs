using System;
using System.Collections.Generic;

namespace Signicat.Express.Addons.Organization
{
    public class OrganizationInformationModel
    {
        /// <summary>
        ///     The name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The organization registration number
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        ///     The organization DUNS number, read more about that here:
        ///     https://en.wikipedia.org/wiki/Data_Universal_Numbering_System
        /// </summary>
        public string DunsNumber { get; set; }

        /// <summary>
        ///     The organizations LEI number, include keyInformation.lei in the expand paramter to get this. Read more about lei
        ///     here: https://en.wikipedia.org/wiki/Legal_Entity_Identifier
        /// </summary>
        public string LeiNumber { get; set; }

        /// <summary>
        ///     The organization type
        /// </summary>
        public OrganizationInformationModelOrganizationType? OrganizationType { get; set; }

        /// <summary>
        ///     The organization phone number if found
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     The resident country for the organization
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        ///     The registration date for the organization
        /// </summary>
        public DateTime? RegisteredDate { get; set; }

        /// <summary>
        ///     The established date for the organization
        /// </summary>
        public DateTime? EstablishedDate { get; set; }

        /// <summary>
        ///     The url for the organization if available
        /// </summary>
        public string Webpage { get; set; }

        /// <summary>
        ///     The purpose for the organization if available
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        ///     Information about how many employees the organization have.
        /// </summary>
        public OrganizationEmployeesModel Employees { get; set; }

        /// <summary>
        ///     List of registries the organization is a member of
        /// </summary>
        public List<string> MemberOfRegistries { get; set; }

        /// <summary>
        ///     Institutional Sector
        /// </summary>
        public OrganizationSectorModel InstitutionalSector { get; set; }

        /// <summary>
        ///     Institutional Sector
        /// </summary>
        public OrganizationSectorModel IndustrySector { get; set; }

        /// <summary>
        ///     List of current status codes for the organization
        /// </summary>
        public List<string> StatusCodes { get; set; }

        /// <summary>
        ///     Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}