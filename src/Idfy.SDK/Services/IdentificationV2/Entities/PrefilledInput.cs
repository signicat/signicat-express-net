using System;

namespace Idfy.IdentificationV2
{
    /// <summary>
    /// Prefilled input values.
    /// </summary>
    public class PrefilledInput
    {
        /// <summary>
        /// Prefill the users' social security number.
        /// </summary>
        public string Ssn { get; set; }

        /// <summary>
        /// Prefill the users' phone number. Must be prefixed with country code.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Prefill the users' date of birth (YYYY-MM-DD).
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Prefill the users' username.
        /// </summary>
        public string Username { get; set; }
    }
}
