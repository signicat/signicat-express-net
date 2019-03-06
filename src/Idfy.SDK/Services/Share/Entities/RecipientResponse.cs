using System;
using System.Collections.Generic;

namespace Idfy.Share.Entities
{
    /// <summary>
    /// Recipient of the secure share
    /// </summary>
    public class RecipientResponse
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Recipients first name 
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Recipients last name 
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Recipients email
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// How long the secure share will be available 
        /// </summary>
        public DateTime Expires { get; set; }
        
        public Mobile Mobile { get; set; }
        
        /// <summary>
        /// List of uploads the recipient can access
        /// </summary>
        public IEnumerable<UploadResponse> Content { get; set; }
        
        /// <summary>
        /// Creators id
        /// </summary>
        public string ExternalId { get; set; }
        
        /// <summary>
        /// The url sent to the recipient 
        /// </summary>
        public string Url { get; set;  }
    }
}