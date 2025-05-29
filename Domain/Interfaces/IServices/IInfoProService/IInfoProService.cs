using TrampoFacil.Application.DTOs.InfoPro;

namespace TrampoFacil.Domain.Interfaces.IServices
{
    public interface IInfoProService
    {
      
        Task<InfoProDTO>AdicionarInfoProAsync(InfoProDTO infoDto);
        
        Task<InfoProDTO>AtualizarInfoProAsync(InfoProDTO infoDto);
        
        Task<InfoProDTO>VisualizarInfoProAsync(Guid IdInfoPro);
        Task <InfoProReadDTO>InfoProNoAnuncioAsync(Guid IdInfoPro);
    }
}