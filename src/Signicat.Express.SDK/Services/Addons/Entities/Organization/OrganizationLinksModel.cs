using System.Collections.Generic;

namespace Signicat.Express.Addons.Organization
{
    public class OrganizationLinksModel
    {
        /// <summary>
        ///     List of reports that is created. Use the same token and poll until you get status code 200.
        /// </summary>
        public List<LinkItemModel> Reports { get; set; }

        /// <summary>
        ///     List of urls to external resources
        /// </summary>
        public List<LinkItemModel> External { get; set; }
    }
}