using System.Collections.Generic;
using System.Linq;

namespace Signicat.Express.Information.Organization
{
    public class OrgQueryParams : QueryParams
    {
        /// <summary>
        /// Optional hint to what kind of id being used.
        /// Allowed values are `organization`, `tax` and `external`, defaults to `organization` and is only used by a limited number of sources.
        /// </summary>
        public string IdType { get; set; }
    }

    public class ExpandableOrgQueryParams : OrgQueryParams
    {
        /// <summary>
        /// Optionally request one or more attributes, by default all available attributes are included.
        /// </summary>
        public IList<string> Expand { get; set; }
    }
}