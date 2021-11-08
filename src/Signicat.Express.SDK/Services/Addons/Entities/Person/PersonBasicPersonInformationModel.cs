using System;

namespace Signicat.Express.Addons.Person
{
    /// <summary>
    /// Basic information about a person
    /// </summary>
    public class PersonBasicPersonInformationModel
    { 
        /// <summary>
        /// Full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// National ID number
        /// </summary>
        public string Ssn { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public PersonBasicPersonInformationModelGender? Gender { get; set; }

        /// <summary>
        /// Sources and other information
        /// </summary>
        public OrganizationPersonMetadata Metadata { get; set; }
    }
}
