namespace Signicat.Express.Addons.Person
{
    public class SignatureObject
    { 
        /// <summary>
        /// Gets or Sets RequirementsDescription
        /// </summary>
        public string RequirementsDescription { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        public RequiredSignatures Required { get; set; }

        /// <summary>
        /// Gets or Sets Others
        /// </summary>
        public OtherSignatures Others { get; set; }
    }
}
