using System.Collections.Generic;

namespace Signicat.Express.Share
{
    public class BucketCreateOptions
    {
        public Information Information { get; set; }
        /// <summary>
        /// List of unique things to share
        /// </summary>

        public IEnumerable<Upload> Content { get; set; }
        /// <summary>
        /// List of the recipients of this secure share
        /// </summary>

        public IEnumerable<Recipient> Recipients { get; set; }
        
        public ContactDetails ContactDetails{ get; set; }
        /// <summary>
        /// List of people sending this share.
        /// </summary>
        public IEnumerable<Sender> Senders { get; set; }
        
        /// <summary>
        /// Optional settings for advanced configuration
        /// </summary>
        public Advanced Advanced { get; set; }
        
    }
}