using System;

namespace Idfy.JWT
{
    public class JwtValidationResult
    {
        /// <summary>Whether the JWT is valid.</summary>
        public bool? Valid { get; set; }
    
        /// <summary>The expiration time on or after which the JWT will not be accepted for processing.</summary>
        public DateTime? Expires { get; set; }
    
        /// <summary>The JWT payload.</summary>
        public object Payload { get; set; }
    
        /// <summary>Error message explaining reason for a failed validation.</summary>
        public string Error { get; set; }
    }
}