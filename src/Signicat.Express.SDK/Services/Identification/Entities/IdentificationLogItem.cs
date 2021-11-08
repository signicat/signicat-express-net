using System;
using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class IdentificationLogItem
    {
        /// <summary>
        /// The identification session ID
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// The full name of the user as reported back from the identity provider if the identification was a success.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// The status of the identification process.
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public IdentificationStatus? Status { get; set; }

        /// <summary>
        /// The IP address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "ClientIp")]
        public string ClientIp { get; set; }

        /// <summary>
        /// The users user-agent (browser/device).
        /// </summary>
        [JsonProperty(PropertyName = "UserAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The identity provider type (Norwegian BanKID, SwedishBankID, Nemid, etc).
        /// </summary>
        [JsonProperty(PropertyName = "IdentityProviderType")]
        public string IdentityProviderType { get; set; }

        /// <summary>
        /// The language used for the identification process.
        /// </summary>
        [JsonProperty(PropertyName = "Language")]
        public string Language { get; set; }

        /// <summary>
        /// The merchants reference to the identification session.
        /// This will also be used to identify an identification in a detailed invoice.
        /// </summary>
        [JsonProperty(PropertyName = "Externalid")]
        public string Externalid { get; set; }

        /// <summary>
        /// The error code for the error.
        /// </summary>
        [JsonProperty(PropertyName = "Errorcode")]
        public string Errorcode { get; set; }

        /// <summary>
        /// The timestamp for the creation of the identification session.
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Whether iframe was used.
        /// </summary>
        [JsonProperty(PropertyName = "iFrame")]
        public bool? Iframe { get; set; }

        /// <summary>
        /// Whether social security number was fetched.
        /// </summary>
        [JsonProperty(PropertyName = "SocialSecurityNumber")]
        public bool? SocialSecurityNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public Guid? AccountId { get; set; }
    }
}