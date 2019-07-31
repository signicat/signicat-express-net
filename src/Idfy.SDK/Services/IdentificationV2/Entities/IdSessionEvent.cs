using System;
using System.Collections.Generic;

namespace Idfy.IdentificationV2
{
    public class IdSessionEvent
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        public IdSessionEventType EventType { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets EventData
        /// </summary>
        public Dictionary<string, Object> EventData { get; set; }
    }
}
