using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class TokenInvalido : AppExceptions
    {
        public TokenInvalido()
            :base("Token Inválido", (int)HttpsStatusCode.Unauthorized)
        {
        }
    }
    
}