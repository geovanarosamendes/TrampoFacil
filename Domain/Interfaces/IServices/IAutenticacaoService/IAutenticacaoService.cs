using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Domain.Interfaces
{

    public interface IAutenticacaoService
    {
         Task<string> LoginAsync(LoginDTO loginDto);
         Task RecuperarSenhaAsync(RecuperacaoDTO recuperacaoDto);
         Task RedefinirSenhaAsync(RedefinirSenhaDTO redefinirDto);
     }
    


}