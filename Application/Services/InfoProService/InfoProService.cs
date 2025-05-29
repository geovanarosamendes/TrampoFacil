using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.InfoPro;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;

namespace TrampoFacil.Application.Services
{
    public class InfoProService : IInfoProService
    {
        private readonly IMapper _mapper;
        private readonly IInfoProRepository _infoProRepository;

        public InfoProService(IMapper mapper, IInfoProRepository infoProRepository)
        {
            _mapper = mapper;

            _infoProRepository = infoProRepository;
        }

    
        


        public async Task<InfoProDTO> AdicionarInfoProAsync(InfoProDTO infoDto)
        {
            var info = _mapper.Map<InfoPro>(infoDto);
            await _infoProRepository.AdicionarInfoProAsync(info);
            return _mapper.Map<InfoProDTO>(infoDto);
        }

        public async Task<InfoProDTO> AtualizarInfoProAsync(InfoProDTO infoDto)
        {
            var info = _mapper.Map<InfoPro>(infoDto);
            await _infoProRepository.AtualizarInfoProAsync(info);

            return _mapper.Map<InfoProDTO>(infoDto);
        }

        public async Task<InfoProReadDTO> InfoProNoAnuncioAsync(Guid IdInfoPro)
        {
            var info = await _infoProRepository.ObterInfoPorIdAsync(IdInfoPro);
            return _mapper.Map<InfoProReadDTO>(info);
        }

        public async Task<InfoProDTO> VisualizarInfoProAsync(Guid IdInfoPro)
        {
            var info = await _infoProRepository.ObterInfoPorIdAsync(IdInfoPro);
            return _mapper.Map<InfoProDTO>(info);
        }

    }
}