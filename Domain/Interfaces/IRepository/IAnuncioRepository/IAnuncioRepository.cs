using Domain.Models;

namespace TrampoFacil.Domain.Interfaces.IRepository
{
    public interface IAnuncioRepository
    {
        Task<Anuncio>CriarAnuncioAsync(Anuncio anuncio);
        Task<Anuncio>EditarAnuncioAsync(Anuncio anuncio);
        Task<Anuncio?>ObterAnuncioPorIdAsync(Guid IdAnuncio);
        Task DeletarAnuncioAsync(Guid IdAnuncio);
        Task<IEnumerable<Anuncio>>BuscarPorTituloAsync(string Titulo);
        Task<IEnumerable<Anuncio>>ObterTodosComUsuarioAsync();

    }
}