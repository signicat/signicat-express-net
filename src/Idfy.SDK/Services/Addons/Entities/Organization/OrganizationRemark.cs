namespace Idfy.Addons.Entities.Organization
{
    /// <summary>
    ///     Remarks to the signing result
    /// </summary>
    public class OrganizationRemark
    {
        /// <summary>
        ///     Different categories of remark
        /// </summary>
        public OrganizationRemarkCategory? Category { get; set; }

        /// <summary>
        ///     Human readable comment to the remark
        /// </summary>
        public string Comment { get; set; }
    }
}