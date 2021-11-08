namespace Idfy.Share
{
    public class Information
    {
        /// <summary>
        /// Title of the secure share, will be presented to the recipient
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description of secure share, will be present in standard notifications
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Creators id for the secure share
        /// </summary>
        public string ExternalId { get; set; }
        /// <summary>
        /// Department id
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        ///  Information not available before the recipient has authenticated itself
        /// </summary>
        public string ConfidentialInfo { get; set; }
    }
}