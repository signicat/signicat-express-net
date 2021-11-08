
 namespace Idfy.Addons.Entities.Person
{
    public class PersonQueryModel : BasePersonQueryModel
    {
        /// <summary>
        /// Date of birth, format YYYYMMDD. National ID number or date of birth is required
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Person firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Person lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// National ID number. National ID number or date of birth is required
        /// </summary>
        public string Ssn { get; set; }
    }
}
