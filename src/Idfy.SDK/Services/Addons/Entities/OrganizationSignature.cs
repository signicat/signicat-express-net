using System;

namespace Idfy.Addons.Entities
{
    public class OrganizationSignature
    { 
        /// <summary>
        /// The name of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date of birth for the person
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The persons role in the organization
        /// </summary>
        public OrganizationSignatureRole? Role { get; set; }
    }
}
