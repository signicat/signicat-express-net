using System.Collections.Generic;

namespace Signicat.Express.IdentificationV2
{
    public class PaginatedData<T>
    {
        /// <summary>
        /// The limit of the current paging options.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// The cursor to send to the endpoint to receive the next batch of responses.
        /// </summary>
        public string NextCursor { get; set; }

        /// <summary>
        /// An array containing the actual response elements.
        /// </summary>
        public IList<T> Data { get; set; }
    }
}
