namespace Idfy.Addons.Entities
{
    public class LeiRecord
    { 
        /// <summary>
        /// Gets or Sets Lei
        /// </summary>
        public string Lei { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        public LeiEntity Entity { get; set; }

        /// <summary>
        /// Gets or Sets Registration
        /// </summary>
        public LeiRegistration Registration { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        public LeiExtension Extension { get; set; }
    }
}
