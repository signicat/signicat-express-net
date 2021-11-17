using System.Collections.Generic;

namespace Signicat.Express.IdentificationV2
{
    public class IdSessionCreateOptions
    {
        /// <summary>
        /// A list of eID providers that can be used for identification. If not specified, the user will be able to chose from all eIDs associated with your Signicat account.
        /// </summary>
        public IList<IdProviderType> AllowedProviders { get; set; }

        /// <summary>
        /// The language to use for the identification process. Defaults to `en` (english).
        /// </summary>
        public Language? Language { get; set; }

        /// <summary>
        /// The type of flow to use.
        /// </summary>
        public IdSessionFlow? Flow { get; set; }
        
        /// <summary>
        /// Request additional information about the user.
        /// </summary>
        public IList<Include> Include { get; set; }

        /// <summary>
        /// Redirect settings when using the `redirect` flow.
        /// </summary>
        public RedirectSettings RedirectSettings { get; set; }

        /// <summary>
        /// Iframe settings when using the `iframe` flow.
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
        /// UI settings for the identification process.
        /// </summary>
        public UiSettings Ui { get; set; }

        /// <summary>
        /// Prefilled input values.
        /// </summary>
        public PrefilledInput PrefilledInput { get; set; }
    }
}
