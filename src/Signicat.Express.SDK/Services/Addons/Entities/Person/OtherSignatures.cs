using System.Collections.Generic;

namespace Signicat.Express.Addons.Person
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
