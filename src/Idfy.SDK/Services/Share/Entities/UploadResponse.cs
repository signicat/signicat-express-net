using System;

namespace Idfy.Share
{
    /// <summary>
    /// Upload information
    /// </summary>
    public class UploadResponse
    {
        /// <summary>
        /// Name of content
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// If the recipient has opened the file 
        /// </summary>
        public bool Opened { get; set; }
        
        /// <summary>
        /// When the file was last opened
        /// </summary>
        public DateTime OpenedDate { get; set; }
    }
}