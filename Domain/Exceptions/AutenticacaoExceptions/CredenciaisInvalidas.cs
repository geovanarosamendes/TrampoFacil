using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class CredenciaisInvalidas
    {
        public CredenciaisInvalidas()
            :base("Credencias Inválidas", (int)HttpsStatusCode.BadRequest)
        {
        }
    }
}