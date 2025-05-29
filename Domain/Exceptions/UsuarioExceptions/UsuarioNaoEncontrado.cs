using System.Net;

namespace TrampoFacil.Exceptions
{
    public class UsuarioNaoEncontrado : AppExceptions
    {
        public UsuarioNaoEncontrado()
            :base("Usuário não encontrado.", (int)HttpStatusCode.NotFound)
        {
        }
    }
}