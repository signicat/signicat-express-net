namespace Idfy.IdentificationV2
{
    /// <summary>
    /// UI settings for the identification process.
    /// </summary>
    public class UiSettings
    {
        /// <summary>
        /// Whether to hide the logo and title of the selected eID provider.
        /// </summary>
        public bool? HideProviderHeader { get; set; }

        /// <summary>
        /// Whether to hide the footer with the language switcher and help button.
        /// </summary>
        public bool? HideFooter { get; set; }
    }
}
