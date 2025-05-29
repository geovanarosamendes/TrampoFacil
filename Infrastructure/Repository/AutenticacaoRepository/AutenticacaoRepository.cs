using Domain.Models;
using Microsoft.EntityFrameworkCore;
using TrampoFacil.Domain.Interfaces;
using TrampoFacil.Infrastructure.Data;

namespace TrampoFacil.Infrastructure.Repository
{
    public class AutenticacaoRepository : IAutenticacaoRepository
    {
        private readonly AppDbContext _context;

        public AutenticacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        

        public async Task<Usuario?>ObterPorLoginAsync(string Login)
        {
           return await _context.Usuario
                .FirstOrDefaultAsync(u => u.Login == Login);
        }

        public async Task AtualizarSenhaAsync(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            await _context.SaveChangesAsync();
        }

        
    }
}