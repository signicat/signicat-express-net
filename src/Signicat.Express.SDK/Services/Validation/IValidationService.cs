using System.Threading.Tasks;

namespace Signicat.Express.Validation
{
    public interface IValidationService
    {
        /// <summary>
        /// Validates the signatures in an SDO.
        /// </summary>
        /// <param name="validateSdoRequest"></param>
        /// <returns></returns>
        ValidateSDOResponse ValidateSDO(ValidateSDORequest validateSdoRequest);

        /// <summary>
        /// Validates the signatures in an SDO.
        /// </summary>
        /// <param name="validateSdoRequest"></param>
        /// <returns></returns>
        Task<ValidateSDOResponse> ValidateSDOAsync(ValidateSDORequest validateSdoRequest);

        /// <summary>
        /// Validates and parses the signatures in an SDO.
        /// </summary>
        /// <param name="parseSdoRequest"></param>
        /// <returns></returns>
        ParseSDOResponse ParseAndValidateSDO(ParseSDORequest parseSdoRequest);

        /// <summary>
        /// Validates and parses the signatures in an SDO.
        /// </summary>
        /// <param name="parseSdoRequest"></param>
        /// <returns></returns>
        Task<ParseSDOResponse> ParseAndValidateSDOAsync(ParseSDORequest parseSdoRequest);
    }
}