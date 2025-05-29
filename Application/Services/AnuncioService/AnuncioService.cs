using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using TrampoFacil.Application.DTOs.Anuncio;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;
using TrampoFacil.Exceptions;

namespace TrampoFacil.Application.Services
{
    public class AnuncioService : IAnuncioService
    {

        private readonly IMapper _mapper;
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioService(IMapper mapper, IAnuncioRepository anuncioRepository)
        {
                _mapper = mapper;
                _anuncioRepository = anuncioRepository;
        }

        public async Task<IEnumerable<AnuncioTituloDTO>> BuscarPorTituloAsync(string Titulo)
        {
            var anuncio = await _anuncioRepository.BuscarPorTituloAsync(Titulo);
            if(anuncio == null)
            {
                throw new AnuncioNaoEncontrado();
            }
            return _mapper.Map<IEnumerable<AnuncioTituloDTO>>(anuncio);
        }

        public async Task<AnuncioReadDTO> CriarAnuncioAsync(AnuncioDTO anuncioDto)
        {
            var anuncio = _mapper.Map<Anuncio>(anuncioDto);
            await _anuncioRepository.CriarAnuncioAsync(anuncio);

            return _mapper.Map<AnuncioReadDTO>(anuncioDto);
        }

        public async Task DeletarAnuncioAsync(Guid IdAnuncio)
        {

            await _anuncioRepository.DeletarAnuncioAsync(IdAnuncio);

        }

        public async Task<AnuncioReadDTO> EditarAnuncioAsync(AnuncioDTO anuncioDto)
        {
            var anuncio = _mapper.Map<Anuncio>(anuncioDto);
            await _anuncioRepository.EditarAnuncioAsync(anuncio);

            return _mapper.Map<AnuncioReadDTO>(anuncioDto);

        }

        public async Task<IEnumerable<AnuncioTituloDTO>> ListarTodosAnunciosAsync()
        {
            var anuncio = await _anuncioRepository.ObterTodosComUsuarioAsync();
            return _mapper.Map<IEnumerable<AnuncioTituloDTO>>(anuncio);
        }

        public async Task<AnuncioReadDTO> VisualizarAnuncioAsync(Guid IdAnuncio)
        {
            var anuncio = await _anuncioRepository.ObterAnuncioPorIdAsync(IdAnuncio);

            return _mapper.Map<AnuncioReadDTO>(anuncio);
        }

        
    }
}