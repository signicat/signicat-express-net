using System;

namespace Signicat.Express.Addons.Organization
{
    /// <summary>
    ///     Beneficial owner
    /// </summary>
    public class BeneficialOwner
    {
        /// <summary>
        ///     The percentage the beneficial owner controls
        /// </summary>
        public double? PercentageControl { get; set; }

        /// <summary>
        ///     The beneficial owners address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        ///     Other information about beneficial owner
        /// </summary>
        public OtherInformation OtherInformation { get; set; }

        /// <summary>
        ///     The name of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     First name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     The persons date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
    }
}