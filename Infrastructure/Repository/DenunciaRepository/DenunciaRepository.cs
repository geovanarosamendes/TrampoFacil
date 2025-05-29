using Domain.Models;
using Microsoft.EntityFrameworkCore;
using TrampoFacil.Application.DTOs.Denuncias;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Infrastructure.Data;

namespace TrampoFacil.Infrastructure.Repository
{
    public class DenunciaRepository : IDenunciaRepository
    {

        private readonly AppDbContext _context;

        public DenunciaRepository(AppDbContext context)
        {
            _context = context;
        }



        public async Task CriarDenunciaAsync(Denuncia denuncia)
        {
            await _context.Denuncia.AddAsync(denuncia);
            await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Denuncia?>> ListarDenunciasAsync()
        {
            return await  _context.Denuncia
                .ToListAsync();
        }

        public async Task<Denuncia?> ObterDenunciaPorIdAsync(Guid IdDenuncia)
        {
            return await _context.Denuncia
                .FirstOrDefaultAsync(d => d.IdDenuncia == IdDenuncia);

        }
    }
}