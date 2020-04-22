using System.Collections.Generic;
using IdentiSign.Addonservices.Models.Aml.Vipps.Organization;

namespace Idfy.Addons
{
    /// <summary>
    /// Contact information
    /// </summary>
    public class PersonContactModel
    {
        /// <summary>
        /// List of available emails
        /// </summary>
        public IEnumerable<EmailModel> Email { get; set; }

        /// <summary>
        /// List of available phone numbers
        /// </summary>
        public IEnumerable<MobileModel> Phone { get; set; }
    }

    /// <summary>
    /// Phone
    /// </summary>
    public class MobileModel
    {
        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// It the phone number is still active, only if information about this is available
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Type of phone, landline/mobile
        /// </summary>
        public PhoneType Type { get; set; }

        /// <summary>
        /// Sources and other information
        /// </summary>
        public PersonMetaData MetaData { get; set; }
    }

    /// <summary>
    /// Email
    /// </summary>
    public class EmailModel
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// If active, only if information available
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Sources 
        /// </summary>
        public PersonMetaData MetaData { get; set; }
    }

    /// <summary>
    /// Type of phone
    /// </summary>
    public enum PhoneType
    {
        /// <summary>
        /// Landline
        /// </summary>
        Landline,

        /// <summary>
        /// Mobile phone 
        /// </summary>
        Mobile
    }
}