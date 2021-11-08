namespace Signicat.Express.Addons.Person
{
    public class SignatureRights
    { 
        /// <summary>
        /// Gets or Sets MvaNumber
        /// </summary>
        public int? MvaNumber { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Signatur
        /// </summary>
        public SignatureObject Signatur { get; set; }

        /// <summary>
        /// Gets or Sets Prokura
        /// </summary>
        public SignatureObject Prokura { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        public string Report { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        public string ReportId { get; set; }
    }
}
