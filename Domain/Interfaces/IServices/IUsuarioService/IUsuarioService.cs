using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Domain.Interfaces.IServices{
    public interface IUsuarioService
    {
        
        Task<UsuarioReadDTO> CadastrarUsuarioAsync(UsuarioDTO usuarioDto);
        Task<UsuarioReadDTO> AtualizarPerfilAsync(UsuarioDTO usuarioDto);
        Task DeletarUsuarioAsync(Guid IdUsuario);
        Task<UsuarioReadDTO> VisualizarPerfilAsync(Guid IdUsuario);
        Task<IEnumerable<UsuarioReadDTO>> BuscarPorNomeAsync(string Nome);
         
    }
}