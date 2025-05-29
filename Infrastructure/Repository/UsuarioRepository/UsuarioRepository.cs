
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using TrampoFacil.Infrastructure.Data;
using TrampoFacil.Domain.Interfaces.IRepository;


namespace TrampoFacil.Infrastructure.Repository{

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context){
             
             _context = context;

        }
         

        public async Task<Usuario> CadastrarUsuarioAsync(Usuario usuario)
        {
            await _context.Usuario.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
       
        public async Task DeletarUsuarioAsync(Guid IdUsuario)
        {
             var usuario = await _context.Usuario.FindAsync(IdUsuario);
            _context.Usuario.Remove(usuario);
            _context.SaveChangesAsync();
            

        }    
        public async Task<IEnumerable<Usuario>> BuscarPorNomeAsync(string Nome)
        {
            return await _context.Usuario
                .Where(u => EF.Functions.ILike(u.Nome, $"%{Nome}%"))
                .ToListAsync();

        }
        public async Task<Usuario?> ObterPorIdAsync(Guid IdUsuario)
        {
            return await _context.Usuario
                .FirstOrDefaultAsync(u => u.IdUsuario == IdUsuario);
        }

        public async Task<Usuario> AtualizarPerfilAsync(Usuario usuario)
        {
             _context.Usuario.Update(usuario);
             await _context.SaveChangesAsync();
             return usuario;
        }

         
        

    }  

}