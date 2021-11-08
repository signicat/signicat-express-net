using System;

namespace Signicat.Express.Addons.Organization
{
    public class CompanyRolePersonAndOrganization
    { 
        /// <summary>
        /// Organization number if object is a organization
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// The name of the person or organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// First name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The persons date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
    }
}
