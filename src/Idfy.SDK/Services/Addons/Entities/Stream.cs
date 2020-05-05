namespace Idfy.Addons.Entities
{
    public class Stream
    { 
        /// <summary>
        /// Gets or Sets CanRead
        /// </summary>
        public bool? CanRead { get; set; }

        /// <summary>
        /// Gets or Sets CanSeek
        /// </summary>
        public bool? CanSeek { get; set; }

        /// <summary>
        /// Gets or Sets CanTimeout
        /// </summary>
        public bool? CanTimeout { get; set; }

        /// <summary>
        /// Gets or Sets CanWrite
        /// </summary>
        public bool? CanWrite { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        public long? Length { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets ReadTimeout
        /// </summary>
        public int? ReadTimeout { get; set; }

        /// <summary>
        /// Gets or Sets WriteTimeout
        /// </summary>
        public int? WriteTimeout { get; set; }
    }
}
