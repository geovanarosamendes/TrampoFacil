using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.Usuario;
using TrampoFacil.Domain.Interfaces;

namespace TrampoFacil.API.Controllers
{
    public class AutenticacaoController : ControllerBase
    {
         private readonly IAutenticacaoService _autenticacaoService;

            public AutenticacaoController(IAutenticacaoService autenticacaoService)
            {
                _autenticacaoService = autenticacaoService;
            }

            //LoginAsync
            [HttpPost("login")]
            public async Task<IActionResult>LoginAsync([FromBody] LoginDTO loginDto)
        {
            var token = await _autenticacaoService.LoginAsync(loginDto);
            return Ok(new { token });
        }
            //RecuperarSenhaAsync
            [HttpPost("recuperar-senha")]
            public async Task<IActionResult>RecuperarSenha([FromBody] RecuperacaoDTO recuperacaoDto)
        {
            await _autenticacaoService.RecuperarSenhaAsync(recuperacaoDto);
            return NoContent();
        }
            //RedefimirSenhaAsync
            [HttpPost("redefinir-senha")]
            public async Task<IActionResult>RedefinirSenha([FromBody] RedefinirSenhaDTO redefinirDto)
        {
            await _autenticacaoService.RedefinirSenhaAsync(redefinirDto);
            return NoContent();
        }
    }
}