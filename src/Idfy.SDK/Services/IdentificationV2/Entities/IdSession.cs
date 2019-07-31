using System;
using System.Collections.Generic;

namespace Idfy.IdentificationV2
{
    public class IdSession
    {
        /// <summary>
        /// The session's unique identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The URL to start the identification process. Only applicable to the `iframe` and `redirect` flows.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The UI reference for the identification process. Only applicable to the `headless` flow.
        /// </summary>
        public string UiRef { get; set; }

        /// <summary>
        /// The status of the identification session.
        /// </summary>
        public IdSessionStatus Status { get; set; }

        /// <summary>
        /// Time at which the session was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Time at which the session will expire.
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        public IdSessionProvider? Provider { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        public Environment Environment { get; set; }

        /// <summary>
        /// A list of eID providers that can be used for identification. If not specified, the user will be able to chose from all eID's associated with your Idfy account.
        /// </summary>
        public List<IdProviderType> Providers { get; set; }

        /// <summary>
        /// The language to use for the identification process. Defaults to `en` (english).
        /// </summary>
        public Language Language { get; set; }

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

        /// <summary>
        /// Gets or Sets AuditTrail
        /// </summary>
        public AuditTrail AuditTrail { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        public Error Error { get; set; }
    }
}
