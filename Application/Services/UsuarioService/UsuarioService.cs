using TrampoFacil.Application.DTOs.Usuario;
using Domain.Models;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;
using AutoMapper;
using TrampoFacil.Exceptions.AutenticacaoExceptions;

namespace TrampoFacil.Application.Services{

    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;

        }

        public async Task<UsuarioReadDTO>CadastrarUsuarioAsync(UsuarioCreateDTO usuarioCreateDto)
        {
           
            var usuario = _mapper.Map<Usuario>(usuarioCreateDto);
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioCreateDto.Senha);


           
            await _usuarioRepository.CadastrarUsuarioAsync(usuario);

            return _mapper.Map<UsuarioReadDTO>(usuario);
            
        } 
        
        public async Task<UsuarioReadDTO>AtualizarPerfilAsync(UsuarioUpdateDTO usuarioUpdateDto)
        {
            
            var usuario = await _usuarioRepository.ObterPorIdAsync(usuarioUpdateDto.IdUsuario);

            if (usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            }
            
            _mapper.Map(usuarioUpdateDto, usuario);
            

            await _usuarioRepository.AtualizarPerfilAsync(usuario);
            
            return _mapper.Map<UsuarioReadDTO>(usuario);
        }

        public async Task DeletarUsuarioAsync (Guid IdUsuario)
        {
           
            var usuario = await _usuarioRepository.ObterPorIdAsync(IdUsuario);

            if(usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            }

            
            await _usuarioRepository.DeletarUsuarioAsync(IdUsuario);

        }

        public async Task<UsuarioReadDTO>VisualizarPerfilAsync(Guid IdUsuario)
        {
            
            var usuario = await _usuarioRepository.ObterPorIdAsync(IdUsuario);

            if (usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            } 
            
            return _mapper.Map<UsuarioReadDTO>(usuario);
        }

        public async Task<IEnumerable<UsuarioReadDTO>>BuscarPorNomeAsync(string Nome)
        {
            
            var usuario = await _usuarioRepository.BuscarPorNomeAsync(Nome);
           
            return _mapper.Map<IEnumerable<UsuarioReadDTO>>(usuario);
        }

        
    }
}