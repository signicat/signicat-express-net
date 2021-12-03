namespace Signicat.Express.Information
{
    public enum OrganizationIdType
    {
        Unknown = 0,

        /// <summary>
        /// Primary id
        /// </summary>
        Organization = 1,

        /// <summary>
        /// Tax or vat number
        /// </summary>
        Tax = 2,

        /// <summary>
        /// External id
        /// </summary>
        External = 3
    }
}