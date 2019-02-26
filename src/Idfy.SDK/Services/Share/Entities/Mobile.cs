namespace Idfy.Share.Entities
{
    public class Mobile
    {
        /// <summary>
        /// Country code, no need to add +
        /// </summary>
        public int CountryCode { get; set; }
        /// <summary>
        /// Valid phonenumber
        /// </summary>
        public string Number { get; set; }
    }
}