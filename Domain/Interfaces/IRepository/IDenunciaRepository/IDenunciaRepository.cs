using Domain.Models;
using TrampoFacil.Application.DTOs.Denuncias;

namespace TrampoFacil.Domain.Interfaces.IRepository
{
    public interface IDenunciaRepository
    {
        Task CriarDenunciaAsync(Denuncia denuncia);
        Task<Denuncia?>ObterDenunciaPorIdAsync(Guid IdDenuncia);
        Task<IEnumerable<Denuncia?>>ListarDenunciasAsync();
    }
}