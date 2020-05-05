using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class SignatureStatusResponse
    { 
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets Organizations
        /// </summary>
        public List<OrganizationResponse> Organizations { get; set; }
    }
}
