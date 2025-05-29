using System.Net;

namespace TrampoFacil.Exceptions
{
    public class AnuncioNaoEncontrado : AppExceptions
    {
        public AnuncioNaoEncontrado()
            :base("Anuncio não encontrado.", (int)HttpStatusCode.NotFound)
        {
        }
    }
}