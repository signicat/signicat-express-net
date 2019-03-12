using System;
using System.Collections.Generic;

namespace Idfy.Share.Entities
{
    public class Recipient
    {
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
        /// How long the fileshare should be available 
        /// </summary>
        public DateTime Expires { get; set; }
        
        public Mobile Mobile { get; set; }
        
        /// <summary>
        /// List of content identificators the recipient can access 
        /// </summary>
        public IEnumerable<string> Content { get; set; }
        
        /// <summary>
        /// Auth providers
        /// </summary>
        public IEnumerable<Authentication> Authentication { get; set; }
        
        public Notification Notification { get; set; }
        
        /// <summary>
        /// Creators id
        /// </summary>
        public string ExternalId { get; set; }
        
        /// <summary>
        /// Restrict the recipient to login once
        /// </summary>
        public bool OneTimeLogin { get; set; }
    }
}