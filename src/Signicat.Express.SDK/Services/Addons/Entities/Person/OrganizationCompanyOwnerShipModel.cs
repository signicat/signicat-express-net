namespace Idfy.Addons.Entities.Person
{
    public class OrganizationCompanyOwnerShipModel
    {
        /// <summary>
        ///     The percentage of share the organization owns.
        /// </summary>
        public double? Percentage { get; set; }

        /// <summary>
        ///     The name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The organization number
        /// </summary>
        public string OrganizationNumber { get; set; }
    }
}