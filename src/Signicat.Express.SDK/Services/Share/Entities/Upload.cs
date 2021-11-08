namespace Idfy.Share
{
    public class Upload
    {
        /// <summary>
        /// Unique id for share 
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Name of upload, will be presented to the user
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// What kind of content is it. Defaults to file
        /// </summary>
        public UploadType Type { get; set; }
    }
}