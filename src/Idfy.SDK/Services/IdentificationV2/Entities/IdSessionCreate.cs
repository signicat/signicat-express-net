using System.Collections.Generic;

namespace Idfy.IdentificationV2
{
    public class IdSessionCreate
    {
        /// <summary>
        /// A list of eID providers that can be used for identification. If not specified, the user will be able to chose from all eID's associated with your Idfy account.
        /// </summary>
        public List<IdProviderType> Providers { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        public IdSessionCreateLanguage? Language { get; set; }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        public IdSessionFlow? Flow { get; set; }

        /// <summary>
        /// Gets or Sets RedirectSettings
        /// </summary>
        public RedirectSettings RedirectSettings { get; set; }

        /// <summary>
        /// Gets or Sets IframeSettings
        /// </summary>
        public IframeSettings IframeSettings { get; set; }

        /// <summary>
        /// Your external reference for the session.
        /// </summary>
        public string ExternalReference { get; set; }

        /// <summary>
        /// The department ID to mark the invoice with.
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Gets or Sets Ui
        /// </summary>
        public UiSettings Ui { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        public AdvancedSettings Advanced { get; set; }
    }
}
