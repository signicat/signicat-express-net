using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signicat.Express.Identification
{
    public class CreateIdentificationRequest
    {
        /// <summary>
        /// The identity provider to use for the identification, if not set the user will get
        /// a list of all the e-ID assosiated with your account to choose from.
        /// </summary>
        [JsonProperty(PropertyName = "IdentityProvider")]
        public IdentityProvider? IdentityProvider { get; set; }

        /// <summary>
        /// The return urls to be redirected to after the identification process is done
        /// </summary>
        [JsonProperty(PropertyName = "ReturnUrls")]
        public ReturnUrls ReturnUrls { get; set; }

        /// <summary>
        /// Iframe settings.
        /// </summary>
        [JsonProperty(PropertyName = "iFrame")]
        public IframeSettings Iframe { get; set; }

        /// <summary>
        /// The language to be used for the identification process, if not set the language of the users browser will be used.
        /// </summary>
        [JsonProperty(PropertyName = "Language")]
        public Language? Language { get; set; }

        /// <summary>
        /// Whether the social security number should be fetched from the identity provider.
        /// </summary>
        [JsonProperty(PropertyName = "GetSocialSecurityNumber")]
        public bool? GetSocialSecurityNumber { get; set; }

        /// <summary>
        /// If this is specified then the client will be prefilled with this value. Supported by Norwegian BankID, NemID and Tupas.
        /// </summary>
        [JsonProperty(PropertyName = "PreFilledSocialSecurityNumber")]
        public string PreFilledSocialSecurityNumber { get; set; }

        /// <summary>
        /// Title of the identification page (Used when redirecting on larger devices). Not used in iframe mode.
        /// </summary>
        [JsonProperty(PropertyName = "PageTitle")]
        public string PageTitle { get; set; }

        /// <summary>
        /// The merchants reference to the identification process,  this will also be used to identify
        /// an identification in a detailed invoice. It is an advantage if this is unique for each API call.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// List of addon data that can be orderd. The result will be in MetaData list of the reponse.
        /// </summary>
        [JsonProperty(PropertyName = "Addonservices")]
        public IDictionary<string, string> Addonservices { get; set; }
    }
}
