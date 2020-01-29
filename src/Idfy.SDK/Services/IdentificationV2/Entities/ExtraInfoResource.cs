namespace Idfy.IdentificationV2
{
    /// <summary>
    /// Resource created for a session.
    /// </summary>
    public class ExtraInfoResource
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        public ExtraInfoResourceType? Type { get; set; }

        /// <summary>
        /// The resource's unique identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The URL to download the resource.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The resource's content type.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// The status of the resource.
        /// </summary>
        public ExtraInfoResourceStatus? Status { get; set; }
    }
}