namespace Signicat.Express.Information.Person
{
    /// <summary>
    /// Query model for a person
    /// </summary>
    public class PersonQueryParams : QueryParams
    {
        /// <summary>
        /// The national identity number used to identify the person
        /// </summary>
        public string IdentityNumber { get; set; }
        
        /// <summary>
        /// The persons given name
        /// </summary>
        public string GivenName { get; set; }
        
        /// <summary>
        /// The persons surname
        /// </summary>
        public string Surname { get; set; }
        
        /// <summary>
        /// The persons date of birth
        /// </summary>
        public string DateOfBirth { get; set; }
        
        /// <summary>
        /// Case reference if required by the source
        /// </summary>
        public string CaseRef { get; set; }

        /// <summary>
        /// the persons street address
        /// </summary>
        public string Street { get; set; }
        
        /// <summary>
        /// the persons street address number
        /// </summary>
        public string StreetNumber { get; set; }
        
        /// <summary>
        /// the persons postal code
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// the persons city place
        /// </summary>
        public string City { get; set; }
    }
}