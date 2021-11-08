using System;
using System.Collections.Generic;

namespace Signicat.Express.Share
{
    public class BucketResponse
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Guid Id { get; set; }
        
        public Information Information{ get; set; }
        
        /// <summary>
        /// List of recipients
        /// </summary>
        public IEnumerable<RecipientResponse> Recipients { get; set; } 
        
        /// <summary>
        /// List of content 
        /// </summary>
        public IEnumerable<ServerUpload> Content { get; set; }
        
        /// <summary>
        /// Number of documents uploaded
        /// </summary>
        public int UploadedDocuments { get; set; }
        
        /// <summary>
        /// Creation time
        /// </summary>
        public DateTime Created { get; set; }
        
        /// <summary>
        /// All content opened or expired
        /// </summary>
        public bool Done { get; set; }
        
        /// <summary>
        /// Deleted by creator
        /// </summary>
        public bool Deleted { get; set; }
        public ContactDetails ContactDetails { get; set; }
        
        /// <summary>
        /// Senders
        /// </summary>
        public IEnumerable<Sender> Senders { get; set; }
        
        /// <summary>
        /// Optional settings for advanced configuration
        /// </summary>
        public Advanced Advanced { get; set; }
    }
}