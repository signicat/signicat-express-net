using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class IdentificationResponse
    {
        /// <summary>
        /// The full name of the user as reported back from the identity provider
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// The first name of the user
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the user (not always available)
        /// </summary>
        [JsonProperty(PropertyName = "MiddleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The users date of birth (not always available)
        /// </summary>
        [JsonProperty(PropertyName = "DateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// The status of the identification process. If not success the identification process is not completed
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public IdentificationStatus? Status { get; set; }

        /// <summary>
        /// The social security number for the user (if allowed and if the GetSocialSecurityNumber is set to true in the request)
        /// </summary>
        [JsonProperty(PropertyName = "SocialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The unique ID from the e-ID.
        /// </summary>
        [JsonProperty(PropertyName = "IdentityProviderUniqueId")]
        public string IdentityProviderUniqueId { get; set; }

        /// <summary>
        /// The identity provider type (Norwegian BanKID, SwedishBankID, Nemid, etc).
        /// </summary>
        [JsonProperty(PropertyName = "IdentityProvider")]
        public IdentityProvider? IdentityProvider { get; set; }

        /// <summary>
        /// Information about error if the identification process failed.
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public Error Error { get; set; }

        /// <summary>
        /// Information about the users environment.
        /// </summary>
        [JsonProperty(PropertyName = "EnvironmentInfo")]
        public EnvironmentInfo EnvironmentInfo { get; set; }

        /// <summary>
        /// A dicitonary with extra information from each identityprovider, and extra services.
        /// See developer documentation for more information.
        /// </summary>
        [JsonProperty(PropertyName = "MetaData")]
        public IDictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The RequestId
        /// </summary>
        [JsonProperty(PropertyName = "RequestId")]
        public string RequestId { get; set; }
    }
}
