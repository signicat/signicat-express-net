using System;
using System.Collections.Generic;

namespace Signicat.Express.IdentificationV2
{
    public class IdSessionEvent
    {
        /// <summary>
        /// The event ID.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        public IdSessionEventType? EventType { get; set; }

        /// <summary>
        /// Time at which the event was raised.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Event data.
        /// </summary>
        public Dictionary<string, object> EventData { get; set; }
    }
}
