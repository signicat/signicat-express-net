using System.Collections.Generic;

namespace Idfy.IdentificationV2
{
    /// <summary>
    /// Iframe settings when using the `iframe` flow.
    /// </summary>
    public class IframeSettings
    {
        /// <summary>
        /// Parent domains that will iframe the session.
        /// </summary>
        public List<string> ParentDomains { get; set; }

        /// <summary>
        /// Target for cross domain messaging.
        /// </summary>
        public string PostMessageTargetOrigin { get; set; }
    }
}