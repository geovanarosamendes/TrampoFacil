using TrampoFacil.Application.DTOs.Usuario;
using Domain.Models;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;
using AutoMapper;
using TrampoFacil.Exceptions.AutenticacaoExceptions;
using TrampoFacil.Exceptions;

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

        public async Task<UsuarioReadDTO>CadastrarUsuarioAsync(UsuarioDTO usuarioDto)
        {
           
            var usuario = _mapper.Map<Usuario>(usuarioDto);
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioDto.Senha);


           
            await _usuarioRepository.CadastrarUsuarioAsync(usuario);

            return _mapper.Map<UsuarioReadDTO>(usuario);
            
        } 
        
        public async Task<UsuarioReadDTO>AtualizarPerfilAsync(UsuarioDTO usuarioDto)
        {
            
            var usuario = _mapper.Map<Usuario>(usuarioDto);
            await _usuarioRepository.AtualizarPerfilAsync(usuario);
            
            return _mapper.Map<UsuarioReadDTO>(usuario);
        }

        public async Task DeletarUsuarioAsync (Guid IdUsuario)
        {
           
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
            if (usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            }
           
            return _mapper.Map<IEnumerable<UsuarioReadDTO>>(usuario);
        }

        
    }
}