using System;
using System.Collections.Generic;

namespace Signicat.Express.Authentication
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
        /// The security reference for the identification process. Only applicable to the `headless` flow.
        /// </summary>
        public string SecurityReference { get; set; }

        /// <summary>
        /// The status of the identification session.
        /// </summary>
        public IdSessionStatus? Status { get; set; }

        /// <summary>
        /// Time at which the session was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Time at which the session will expire.
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// The eID provider used for identification.
        /// </summary>
        public IdProviderType? Provider { get; set; }

        /// <summary>
        /// Details about the identified user. Only available if session has status `success`.
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Details about the user's environment.
        /// </summary>
        public Environment Environment { get; set; }

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
        ///  UI settings for the identification process.
        /// </summary>
        public UiSettings Ui { get; set; }

        /// <summary>
        /// Prefilled input values.
        /// </summary>
        public PrefilledInput PrefilledInput { get; set; }
        
        /// <summary>
        /// Resources created for the session.
        /// </summary>
        public IList<ExtraInfoResource> Resources { get; set; }

        /// <summary>
        /// Audit trail.
        /// </summary>
        public AuditTrail AuditTrail { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        public Error Error { get; set; }
    }
}
