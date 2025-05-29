
using TrampoFacil.Application.DTOs.Anuncio;

namespace TrampoFacil.Domain.Interfaces.IServices
{

    
    public interface IAnuncioService
    {
       
        Task<AnuncioReadDTO>CriarAnuncioAsync(AnuncioDTO anuncioDto);
        
        Task<AnuncioReadDTO>EditarAnuncioAsync(AnuncioDTO anuncioDto);
        
        Task<AnuncioReadDTO>VisualizarAnuncioAsync(Guid IdAnuncio);
       
        Task DeletarAnuncioAsync(Guid IdAnuncio);
        
        Task<IEnumerable<AnuncioTituloDTO>>BuscarPorTituloAsync(string Titulo);
        Task<IEnumerable<AnuncioTituloDTO>>ListarTodosAnunciosAsync();

    }
}