using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Infrastructure;

namespace Idfy.Validation
{
    /// <summary>
    /// Validate signatures from supported eID providers.
    /// </summary>
    public class ValidationService : IdfyBaseService
    {
        public ValidationService()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scopes"></param>
        public ValidationService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes) :
            base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Validates the signatures in an SDO.
        /// </summary>
        /// <param name="validateSdoRequest"></param>
        /// <returns></returns>
        public ValidateSDOResponse ValidateSDO(ValidateSDORequest validateSdoRequest)
        {
            return Post<ValidateSDOResponse>($"{Urls.Validation}/no/bankid/validate");
        }
        
        /// <summary>
        /// Validates the signatures in an SDO.
        /// </summary>
        /// <param name="validateSdoRequest"></param>
        /// <returns></returns>
        public async Task<ValidateSDOResponse> ValidateSDOAsync(ValidateSDORequest validateSdoRequest)
        {
            return await PostAsync<ValidateSDOResponse>($"{Urls.Validation}/no/bankid/validate");
        }

        /// <summary>
        /// Validates and parses the signatures in an SDO.
        /// </summary>
        /// <param name="parseSdoRequest"></param>
        /// <returns></returns>
        public ParseSDOResponse ParseAndValidateSDO(ParseSDORequest parseSdoRequest)
        {
            return Post<ParseSDOResponse>($"{Urls.Validation}/no/bankid/parse");
        }
        
        /// <summary>
        /// Validates and parses the signatures in an SDO.
        /// </summary>
        /// <param name="parseSdoRequest"></param>
        /// <returns></returns>
        public async Task<ParseSDOResponse> ParseAndValidateSDOAsync(ParseSDORequest parseSdoRequest)
        {
            return await PostAsync<ParseSDOResponse>($"{Urls.Validation}/no/bankid/parse");
        }
    }
}