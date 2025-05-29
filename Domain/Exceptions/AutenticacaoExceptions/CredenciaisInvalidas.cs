using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class CredenciaisInvalidas : AppExceptions
    {
        public CredenciaisInvalidas()
            :base("Credencias Inválidas", (int)HttpStatusCode.BadRequest)
        {
        }
    }
}