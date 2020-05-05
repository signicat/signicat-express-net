using System.Collections.Generic;

namespace Idfy.Addons.Entities.Person
{
    public class OtherSignatures
    { 
        /// <summary>
        /// Gets or Sets RequiredNumberOfOthers
        /// </summary>
        public int? RequiredNumberOfOthers { get; set; }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        public List<Signature> List { get; set; }
    }
}
