using System.Collections.Generic;

namespace Signicat.Express.Addons.Organization
{
    public class OrganizationSigningOptionModel
    { 
        /// <summary>
        /// List of required signers
        /// </summary>
        public List<OrganizationSignature> Required { get; set; }
    }
}
