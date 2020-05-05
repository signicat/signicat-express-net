using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OrganizationRequest
    { 
        /// <summary>
        /// Gets or Sets OrgNumber
        /// </summary>
        public string OrgNumber { get; set; }

        /// <summary>
        /// Gets or Sets Prokura
        /// </summary>
        public bool? Prokura { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        public bool? Signature { get; set; }

        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        public List<CheckSignature> Signatures { get; set; }
    }
}
