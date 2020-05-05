namespace Idfy.Addons.Entities
{
    /// <summary>
    /// Response object for screened person
    /// </summary>
    public class PersonPersonResponseModel
    { 
        /// <summary>
        /// Key information
        /// </summary>
        public PersonBasicPersonInformationModel KeyInformation { get; set; }

        /// <summary>
        /// Information from ID provider
        /// </summary>
        public PersonPersonIdInformation Identity { get; set; }

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
