namespace Idfy.Share.Entities
{
    public class ServerUpload
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Content { get; set; }
        
        public UploadType Type { get; set; }
    }
}