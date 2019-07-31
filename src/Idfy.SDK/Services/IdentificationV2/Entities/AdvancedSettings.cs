namespace Idfy.IdentificationV2
{
    /// <summary>
    /// Advanced settings.
    /// </summary>
    public class AdvancedSettings
    {
        /// <summary>
        /// Whether to get the user's social securty number.
        /// </summary>
        public bool? GetSsn { get; set; }

        /// <summary>
        /// Gets or Sets PrefilledInput
        /// </summary>
        public PrefilledInput PrefilledInput { get; set; }
    }
}
