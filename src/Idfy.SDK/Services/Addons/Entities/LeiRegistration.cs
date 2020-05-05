using System;

namespace Idfy.Addons.Entities
{
    public class LeiRegistration
    { 
        /// <summary>
        /// Gets or Sets InitialRegistrationDate
        /// </summary>
        public DateTime? InitialRegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationStatus
        /// </summary>
        public string RegistrationStatus { get; set; }

        /// <summary>
        /// Gets or Sets ValidationSources
        /// </summary>
        public string ValidationSources { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateDate
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Gets or Sets NextRenewalDate
        /// </summary>
        public DateTime? NextRenewalDate { get; set; }

        /// <summary>
        /// Gets or Sets ManagingLou
        /// </summary>
        public ManagingLou ManagingLou { get; set; }
    }
}
