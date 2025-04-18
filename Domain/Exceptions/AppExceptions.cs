using System;
using System.Net;

namespace TrampoFacil.Exceptions
{
    public class AppExceptions : Exceptions
    {
        public int StatusCode {get;}

        public AppExceptions(string message, int statusCode = (int)HttpsStatusCode.BadRequest)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}