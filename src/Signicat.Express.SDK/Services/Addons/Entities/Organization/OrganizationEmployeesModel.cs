namespace Signicat.Express.Addons.Organization
{
    /// <summary>
    ///     Information about how many employees the organization have.
    /// </summary>
    public class OrganizationEmployeesModel
    {
        /// <summary>
        ///     Employees from
        /// </summary>
        public int? From { get; set; }

        /// <summary>
        ///     Employees to
        /// </summary>
        public int? To { get; set; }
    }
}