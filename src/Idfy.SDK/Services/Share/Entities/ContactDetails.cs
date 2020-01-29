namespace Idfy.Share
{
    public class ContactDetails
    {
        /// <summary>
        /// Name to present to the recipient
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Phone number recipient can contact 
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// Email recipient can contact 
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Web page the recipient can visit
        /// </summary>
        public string Url { get; set; }
    }
}