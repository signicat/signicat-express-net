using System.Collections.Generic;

namespace Idfy.IdentificationV2
{
    /// <summary>
    /// Audit trail.
    /// </summary>
    public class AuditTrail
    {
        /// <summary>
        /// The certificate used to identify the user.
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Events raised for the current session.
        /// </summary>
        public List<IdSessionEvent> Events { get; set; }
    }
}
