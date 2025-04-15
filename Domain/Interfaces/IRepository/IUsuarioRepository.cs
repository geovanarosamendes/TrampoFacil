using Usuarios.Models;

namespace TrampoFacil.Domain.Interfaces.Repository{
public interface IUsuarioRepository
    {
        Task<Usuario> GetByIdAsync(Guid id);
        
        /*Task<IEnumerable<Usuario>> GetAllAsync();
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(Guid id);
        Task<Usuario?> GetByEmailAsync(string Email);*/
    }

}