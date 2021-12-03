namespace Signicat.Express.Information
{
    public class ScreenQuery
    {
        /// <summary>
        /// Comma-separated string of list types to screen against, defaults to all lists. Allowed values are `pep`, `sanction` and `adverseMedia`.
        /// </summary>
        public string ListType { get; set; }
    }
}