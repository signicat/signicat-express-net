using System.Collections.Generic;
using Idfy.Addons.Entities.Person;

namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationSignatureModel
    { 
        /// <summary>
        /// Status of signing rights
        /// </summary>
        public OrganizationSignatureModelStatus? Status { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A list of different options for valid signatures
        /// </summary>
        public List<OrganizationSigningOptionModel> Options { get; set; }

        /// <summary>
        /// List of remarks for the signature model.
        /// </summary>
        public List<OrganizationRemark> Remarks { get; set; }
    }
}
