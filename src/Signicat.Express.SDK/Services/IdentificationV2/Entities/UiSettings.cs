namespace Signicat.Express.IdentificationV2
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
        
        /// <summary>
        /// Whether to use light or dark theme.
        /// </summary>
        public ThemeMode? ThemeMode { get; set; }
        
        /// <summary>
        /// The color theme to use.
        /// </summary>
        public ColorTheme? ColorTheme { get; set; }
    }
}
