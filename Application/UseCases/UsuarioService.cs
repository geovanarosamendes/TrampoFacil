using TrampoFacil.Application.DTOs.Usuario;
using Usuarios.Models;
using TrampoFacil.Domain.Interfaces.Repository;
using TrampoFacil.Domain.Interfaces.Services;

namespace TrampoFacil.Application.Services{

    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        /*public async Task<UsuarioCreateDTO> GetByIdAsync(Guid id)
        {
            
        }*/
    }
}