namespace Signicat.Express.Information
{
    public class PagedQuery
    {
        /// <summary>
        /// Used for paging
        /// </summary>
        public int? Offset { get; set; } = 0;

        /// <summary>
        /// Set how many results you want per page (max/default 100)
        /// </summary>
        public int? Limit { get; set; } = 100;
    }

    public class CursorQuery
    {
        /// <summary>
        /// Cursor returned for paginating multiple sources, cannot be used together with `offset` and `limit`.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Used for paging
        /// </summary>
        public int? Offset { get; set; }
        
        /// <summary>
        /// Set how many results you want per page (max/default 100)
        /// </summary>
        public int? Limit { get; set; }
    }
}