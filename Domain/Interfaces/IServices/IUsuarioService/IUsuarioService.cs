using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Domain.Interfaces.IServices{
    public interface IUsuarioService
    {
        
        Task<UsuarioReadDTO> CadastrarUsuarioAsync(UsuarioCreateDTO usuarioCreateDto);
        Task<UsuarioReadDTO> AtualizarPerfilAsync(UsuarioUpdateDTO usuarioUpdateDto);
        Task DeletarUsuarioAsync(Guid IdUsuario);
        Task<UsuarioReadDTO> VisualizarPerfilAsync(Guid IdUsuario);
        Task<IEnumerable<UsuarioReadDTO>> BuscarPorNomeAsync(string Nome);
         
    }
}