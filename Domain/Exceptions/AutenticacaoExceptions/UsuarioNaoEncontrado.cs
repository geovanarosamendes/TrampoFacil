using System;
using System.Net;

namespace TrampoFacil.Exceptions.AutenticacaoExceptions
{
    public class UsuarioNaoEncontrado : AppExceptions
    {
        public UsuarioNaoEncontrado()
            :base("Usuário não encontrado.", (int)HttpsStatusCode.NotFound)
        {
        }
    }
}