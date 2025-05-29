using AutoMapper;
using Domain.Models;
using Microsoft.IdentityModel.Tokens;
using TrampoFacil.Application.DTOs.Denuncias;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;
using TrampoFacil.Exeptions;

namespace TrampoFacil.Application.Services
{
    public class DenunciaService : IDenunciaService
    {

        private readonly IMapper _mapper;
        private readonly IDenunciaRepository _denunciaRepository;

        public DenunciaService(IMapper mapper, IDenunciaRepository denunciaRepository)
        {
            _mapper = mapper;
            _denunciaRepository = denunciaRepository;
        }



        public async Task<DenunciaReadDTO> CriarDenunciaAsync(DenunciaDTO denunciaDto)
        {
            var denuncia = _mapper.Map<Denuncia>(denunciaDto);
            await _denunciaRepository.CriarDenunciaAsync(denuncia);
            return _mapper.Map<DenunciaReadDTO>(denuncia);
        }

        public async Task<IEnumerable<DenunciaTituloDTO>> ListarDenunciasAsync()
        {
            var denuncia = await _denunciaRepository.ListarDenunciasAsync();
            if(denuncia == null)
            {
                throw new SemDenuncias();
            }
            return _mapper.Map<IEnumerable<DenunciaTituloDTO>>(denuncia);
        }

        public async Task<DenunciaReadDTO> VerDenunciasAsync(Guid IdDenuncia)
        {
            var denuncia = await _denunciaRepository.ObterDenunciaPorIdAsync(IdDenuncia);
            return _mapper.Map<DenunciaReadDTO>(denuncia);
        }
    }
}