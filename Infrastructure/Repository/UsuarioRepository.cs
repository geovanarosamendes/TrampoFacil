
using Microsoft.EntityFrameworkCore;
using Usuarios.Models;
using TrampoFacil.Infrastructure.Data;
using TrampoFacil.Domain.Interfaces.Repository;


namespace TrampoFacil.Infrastructure.Repository{

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context){
             
             _context = context;

        }
         

         public async Task<Usuario> GetByIdAsync(Guid id)
         {
             var usuario = await _context.Usuarios.FindAsync(id);


             if (usuario is null)
                throw new Exception("Usuário não encontrado");


            return usuario;
        
         }

         
        /*public async Task<IEnumerable<Usuario>> GetAllAsync();
        public async Task AddAsync(Usuario usuario);
        public async Task UpdateAsync(Usuario usuario);
        public async Task DeleteAsync(Guid id);
        public async Task<Usuario?> GetByEmailAsync(string Email);*/

    }  

}