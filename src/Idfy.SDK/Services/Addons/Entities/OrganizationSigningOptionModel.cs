using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OrganizationSigningOptionModel
    { 
        /// <summary>
        /// List of required signers
        /// </summary>
        public List<OrganizationSignature> Required { get; set; }
    }
}
