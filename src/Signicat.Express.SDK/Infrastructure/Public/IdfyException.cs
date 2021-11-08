using System;
using System.Net;
using Signicat.Express;

namespace Signicat.Express
{
    public class IdfyException : Exception
    {
        public IdfyException(HttpStatusCode statusCode, IdfyError error, IdfyResponse response, string message) :
            base(message ?? $"The server returned status code {(int) statusCode}")
        {
            HttpStatusCode = statusCode;
            Error = error;
            Response = response;
        }
        
        public HttpStatusCode HttpStatusCode { get; }
        
        public IdfyResponse Response { get; }
        
        public IdfyError Error { get; }
    }
}