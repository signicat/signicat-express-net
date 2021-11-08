using Idfy.Addons.Entities.Organization;

namespace Idfy.Addons.Entities.Person
{
    /// <summary>
    /// Response object for screened person
    /// </summary>
    public class PersonResponseModel
    { 
        /// <summary>
        /// Key information
        /// </summary>
        public PersonBasicPersonInformationModel KeyInformation { get; set; }

        /// <summary>
        /// Information from ID provider
        /// </summary>
        public PersonIdInformation Identity { get; set; }

        /// <summary>
        /// Address information
        /// </summary>
        public PersonAddressModel Address { get; set; }

        /// <summary>
        /// AML data
        /// </summary>
        public PersonAmlModel Aml { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        public OrganizationLinksModel Links { get; set; }
    }
}
