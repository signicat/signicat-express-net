namespace Idfy.Share
{
    public class BucketUpdateOptions
    {
        /// <summary>
        /// Title of the secure share, will be presented to the recipient 
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Description of secure share, will be present in standard notifications
        /// </summary>
        public string Description { get; set; }
        
        public ContactDetails ContactDetails { get; set; }
    }
}