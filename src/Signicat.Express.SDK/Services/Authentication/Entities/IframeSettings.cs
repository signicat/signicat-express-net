using System.Collections.Generic;

namespace Signicat.Express.Authentication
{
    /// <summary>
    /// Iframe settings when using the `iframe` flow.
    /// </summary>
    public class IframeSettings
    {
        /// <summary>
        /// Parent domains that will iframe the session.
        /// </summary>
        public IList<string> ParentDomains { get; set; }

        /// <summary>
        /// Target origin for cross domain messaging.
        /// </summary>
        public string PostMessageTargetOrigin { get; set; }
    }
}