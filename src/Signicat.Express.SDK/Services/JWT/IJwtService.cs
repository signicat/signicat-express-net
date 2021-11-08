using System.Threading.Tasks;

namespace Idfy.JWT
{
    public interface IJwtService
    {
        /// <summary>
        /// Validates a JWT.
        /// </summary>
        /// <param name="jwtValidationRequest"></param>
        /// <returns></returns>
        JwtValidationResult Validate(JwtValidationRequest jwtValidationRequest);

        /// <summary>
        /// Validates a JWT.
        /// </summary>
        /// <param name="jwtValidationRequest"></param>
        /// <returns></returns>
        Task<JwtValidationResult> ValidateAsync(JwtValidationRequest jwtValidationRequest);
    }
}