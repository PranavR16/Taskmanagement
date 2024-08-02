using System;
using System.Net;

namespace TaskManagementSystem.Api.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public object ErrorDetails { get; set; }

        public ApiException(HttpStatusCode statusCode, string message, object errorDetails = null)
            : base(message)
        {
            StatusCode = statusCode;
            ErrorDetails = errorDetails;
        }
    }
}
