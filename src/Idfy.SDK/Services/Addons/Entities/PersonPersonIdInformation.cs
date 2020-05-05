namespace Idfy.Addons.Entities
{
    /// <summary>
    /// Information coming from persons ID method
    /// </summary>
    public class PersonPersonIdInformation
    { 
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// National ID number
        /// </summary>
        public string Ssn { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        public OrganizationPersonMetadata Metadata { get; set; }
    }
}
