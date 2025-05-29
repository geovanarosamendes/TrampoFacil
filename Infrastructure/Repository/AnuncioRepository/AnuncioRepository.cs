using Domain.Models;
using Microsoft.EntityFrameworkCore;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Infrastructure.Data;

namespace TrampoFacil.Infrastructure.Repository
{

    public class AnuncioRepository : IAnuncioRepository
    {

        private readonly AppDbContext _context;

        public AnuncioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Anuncio>> BuscarPorTituloAsync(string Titulo)
        {
            return await _context.Anuncio
                .Where(a => EF.Functions.ILike(a.Titulo, $"%{Titulo}%"))
                .ToListAsync();
            
        }

        public async Task<Anuncio> CriarAnuncioAsync(Anuncio anuncio)
        {
           await _context.AddAsync(anuncio);
           await _context.SaveChangesAsync();
           return anuncio;

        }

        public async Task DeletarAnuncioAsync(Guid IdAnuncio)
        {
            var anuncio = await _context.Anuncio.FindAsync(IdAnuncio);
            if(anuncio != null)
            {
                _context.Anuncio.Remove(anuncio);
                await _context.SaveChangesAsync();
            }
            

        }

        public async Task<Anuncio> EditarAnuncioAsync(Anuncio anuncio)
        {
            _context.Anuncio.Update(anuncio);
            await _context.SaveChangesAsync();
            return anuncio;

        }

        public async Task<Anuncio?> ObterAnuncioPorIdAsync(Guid IdAnuncio)
        {
            return await _context.Anuncio
                .FirstOrDefaultAsync(a => a.IdAnuncio == IdAnuncio);
        }

        public async Task<IEnumerable<Anuncio>> ObterTodosComUsuarioAsync()
        {
            return await _context.Anuncio
                .Include(a => a.Usuario)
                .ToListAsync();
        }
    }
}