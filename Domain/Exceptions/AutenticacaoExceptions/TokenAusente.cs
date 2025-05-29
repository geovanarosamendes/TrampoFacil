using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class TokenAusente : AppExceptions
    {
        public TokenAusente()
            :base("Token de acesso não encontrado",(int)HttpStatusCode.Unauthorized)
        {
        }
    }
}