using Domain.Models;
using TrampoFacil.Application.DTOs.Usuario;
using TrampoFacil.Domain.Interfaces;
using TrampoFacil.Exceptions;
using TrampoFacil.Exceptions.AutenticacaoExceptions;

namespace TrampoFacil.Application.Services
{
    public class AutenticacaoService : IAutenticacaoService

    {
        private readonly IAutenticacaoRepository _autenticacaoRepository;
        private readonly TokenGeneratorService _tokenGeneratorService;
        public AutenticacaoService(IAutenticacaoRepository autenticacaoRepository, TokenGeneratorService tokenGeneratorService)
        {
            _autenticacaoRepository = autenticacaoRepository;
            _tokenGeneratorService = tokenGeneratorService;
        }

        public async Task<string> LoginAsync(LoginDTO loginDto)
        {
            var usuario = await _autenticacaoRepository.ObterPorLoginAsync(loginDto.Login);
            if(usuario == null || !BCrypt.Net.BCrypt.Verify(loginDto.Senha, usuario.Senha))
            {
                throw new CredenciaisInvalidas();
            }

            var token = _tokenGeneratorService.GerarToken(usuario);
            return token;
        }

        public async Task RecuperarSenhaAsync(RecuperacaoDTO recuperacaoDto)
        {
            var usuario = await _autenticacaoRepository.ObterPorLoginAsync(recuperacaoDto.Login);
            if(usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            }

        }

        public async Task RedefinirSenhaAsync(RedefinirSenhaDTO redefinirDto)
        {
            var usuario = await _autenticacaoRepository.ObterPorLoginAsync(redefinirDto.NovaSenha);
            if (usuario == null)
            {
                throw new UsuarioNaoEncontrado();
            }

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(redefinirDto.NovaSenha);

            await _autenticacaoRepository.AtualizarSenhaAsync(usuario);
        }
    }
}