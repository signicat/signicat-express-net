namespace Signicat.Express.Information
{
    public class QueryParams
    {
        /// <summary>
        /// Optional name of the source to use
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Optionally include the raw data received from the upstream if supported by the source
        /// </summary>
        public bool RawJson { get; set; }
    }
    
}