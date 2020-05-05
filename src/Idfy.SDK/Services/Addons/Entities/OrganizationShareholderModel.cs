using System;

namespace Idfy.Addons.Entities
{
    public class OrganizationShareholderModel
    { 
        /// <summary>
        /// The name of the share holder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Organization number if the share holder is an organization, if a the shareholder is a person this is empty.
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// The percentage the share holder owns.
        /// </summary>
        public double? Percentage { get; set; }

        /// <summary>
        /// Date of birth  if the share holder is an person, if a the shareholder is a organization this is empty.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The type of owner, person or organization.
        /// </summary>
        public OrganizationShareholderModelType? Type { get; set; }
    }
}
