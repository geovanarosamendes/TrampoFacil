
using TrampoFacil.Application.DTOs.Denuncias;

namespace TrampoFacil.Domain.Interfaces.IServices
{
    public interface IDenunciaService
    {
       
        Task<DenunciaReadDTO>CriarDenunciaAsync(DenunciaDTO denunciaDto);
       
        Task<DenunciaReadDTO>VerDenunciasAsync(Guid IdDenuncia);
        Task<IEnumerable<DenunciaTituloDTO>>ListarDenunciasAsync();
    }
}