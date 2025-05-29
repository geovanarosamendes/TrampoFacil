using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Sprache;
using TrampoFacil.Application.DTOs.InfoPro;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Infrastructure.Data;

namespace TrampoFacil.Infrastructure.Repository
{
    public class InfoProRepository : IInfoProRepository
    {

        private readonly AppDbContext _context;

        public InfoProRepository(AppDbContext context)
        {
            _context = context;
        }




        public async Task<InfoPro> AdicionarInfoProAsync(InfoPro infoPro)
        {
            await _context.InfoPro.AddAsync(infoPro);
            await _context.SaveChangesAsync();
            return infoPro;
        }

        public async Task<InfoPro> AtualizarInfoProAsync(InfoPro infoPro)
        {
            _context.InfoPro.Update(infoPro);
            await _context.SaveChangesAsync();
            return infoPro;
        }

        public async Task<InfoPro?> ObterInfoPorIdAsync(Guid IdInfoPro)
        {
           return await _context.InfoPro
            .FirstOrDefaultAsync(ip => ip.IdInfoPro == IdInfoPro);
        }
    }
}