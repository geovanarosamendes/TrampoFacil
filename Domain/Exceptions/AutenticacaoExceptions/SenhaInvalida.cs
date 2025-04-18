using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class SenhaInvalida : AppExceptions
    {
        public SenhaInvalida()
            :base("Senha inválida", (int)HttpsStatusCode.BadRequest)
        {
        }
    }
}