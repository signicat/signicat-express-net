using System.Collections.Generic;
using System.Threading.Tasks;
using Signicat.Express.Infrastructure;

namespace Signicat.Express.JWT
{
    /// <summary>
    /// Validate JSON Web Tokens from Idfy.
    /// </summary>
    public class JwtService : IdfyBaseService, IJwtService
    {
        public JwtService()
        {
        }

        public JwtService(string clientId, string clientSecret, IEnumerable<string> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }
        
        public JwtService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Validates a JWT.
        /// </summary>
        /// <param name="jwtValidationRequest"></param>
        /// <returns></returns>
        public JwtValidationResult Validate(JwtValidationRequest jwtValidationRequest)
        {
            return Post<JwtValidationResult>($"{Urls.Jwt}/validate", jwtValidationRequest);
        }
        
        /// <summary>
        /// Validates a JWT.
        /// </summary>
        /// <param name="jwtValidationRequest"></param>
        /// <returns></returns>
        public async Task<JwtValidationResult> ValidateAsync(JwtValidationRequest jwtValidationRequest)
        {
            return await PostAsync<JwtValidationResult>($"{Urls.Jwt}/validate", jwtValidationRequest);
        }
    }
}