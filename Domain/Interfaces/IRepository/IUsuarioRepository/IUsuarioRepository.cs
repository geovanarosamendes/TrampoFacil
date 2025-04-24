using Domain.Models;

namespace TrampoFacil.Domain.Interfaces.IRepository{
public interface IUsuarioRepository
    {
       Task<Usuario> CadastrarUsuarioAsync(Usuario usuario);
       Task<Usuario> AtualizarPerfilAsync(Usuario usuario);
       Task DeletarUsuarioAsync(Guid IdUsuario);
       Task<IEnumerable<Usuario>> BuscarPorNomeAsync(string Nome);
       Task<Usuario?> ObterPorIdAsync(Guid IdUsuario);
    }

}