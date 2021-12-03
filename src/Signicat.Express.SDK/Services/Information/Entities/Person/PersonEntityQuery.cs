namespace Signicat.Express.Information.Person
{
    public class PersonEntityQuery : GlobalEntityQuery
    {
        /// <summary>
        /// Date of birth of the entity to search for, accepted formats: `yyyy-MM-dd`, `yyyy-MM` or `yyyy`
        /// </summary>
        public string DateOfBirth { get; set; }
        
        /// <summary>
        /// Search person through postal code
        /// </summary>
        public string PostalCode { get; set; }
    }
}