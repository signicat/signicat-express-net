using System;

namespace Idfy.Addons.Entities.Organization
{
    public class CompanyPerson
    { 
        /// <summary>
        /// The name of the person
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
