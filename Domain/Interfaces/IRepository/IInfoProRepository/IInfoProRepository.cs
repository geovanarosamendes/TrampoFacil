using Domain.Models;
using TrampoFacil.Application.DTOs.InfoPro;

namespace TrampoFacil.Domain.Interfaces.IRepository
{
    public interface IInfoProRepository
    {
        Task<InfoPro>AdicionarInfoProAsync(InfoPro infoPro);
        Task<InfoPro>AtualizarInfoProAsync(InfoPro infoPro);
        Task<InfoPro?>ObterInfoPorIdAsync(Guid IdInfoPro);
        
    }
}