namespace Signicat.Express.IdentificationV2
{
    public class AppIdProvider
    {
        /// <summary>
        /// A unique identifier for the ID provider.
        /// </summary>
        public IdProviderType? Type { get; set; }

        /// <summary>
        /// The name of the ID provider.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short description of the ID provider.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The URL to the ID provider's logo.
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// The URL to the ID provider's logo (negative version).
        /// </summary>
        public string LogoUrlNegative { get; set; }

        /// <summary>
        /// The width of the logo. A width of 100% will be used if this property is not set.
        /// </summary>
        public string LogoWidth { get; set; }
    }
}
