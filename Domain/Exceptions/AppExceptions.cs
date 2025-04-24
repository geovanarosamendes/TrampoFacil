using System;
using System.Net;

namespace TrampoFacil.Exceptions
{
    public class AppExceptions : Exception
    {
        public int StatusCode {get;}

        public AppExceptions(string message, int statusCode = (int)HttpStatusCode.BadRequest)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}