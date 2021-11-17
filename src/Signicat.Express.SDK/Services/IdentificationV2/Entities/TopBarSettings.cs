namespace Signicat.Express.IdentificationV2
{
    /// <summary>
    /// Add a top bar to the identification process.
    /// </summary>
    public class TopBarSettings
    {
        /// <summary>
        /// The title to display in the top bar.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The top bar's foreground color (hex code).
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        /// The top bar's background color (hex code).
        /// </summary>
        public string BackgroundColor { get; set; }
    }
}