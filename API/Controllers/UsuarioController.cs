using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrampoFacil.API.Helpers;
using TrampoFacil.Application.DTOs.Usuario;
using TrampoFacil.Domain.Interfaces.IServices;

namespace TrampoFacil.API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
         private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        
        [HttpPost]
        public async Task<IActionResult>CadastrarUsuarioAsync([FromBody] UsuarioDTO usuarioDto)
        {
                var dadosDeCadastro = await _usuarioService.CadastrarUsuarioAsync(usuarioDto);

                return Created("", dadosDeCadastro);

        }

        [Authorize]
        [HttpPut]
         public async Task<IActionResult>AtualizarPerfilAsync([FromBody] UsuarioDTO usuarioDto)
        {
            var usuarioAtualizado = await _usuarioService.AtualizarPerfilAsync(usuarioDto);
            return Ok(usuarioAtualizado);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult>DeletarUsuarioAsync()
        {
            var idUsuario = UsuarioHelper.ObterIdUsuarioLogado(HttpContext);

            await _usuarioService.DeletarUsuarioAsync(idUsuario);
            return NoContent();
        }

        [Authorize]
        [HttpGet("{IdUsuario}")]
        public async Task<IActionResult>VisualizarPerfilAsync(Guid IdUsuario)
        {
            var verUsuario = await  _usuarioService.VisualizarPerfilAsync(IdUsuario);
            return Ok(verUsuario);
        }

        [Authorize]
        [HttpGet("buscar")]
        public async Task<IActionResult>BuscarPorNomeAsync([FromQuery] string Nome)
        {
            var usuarioBuscado = await _usuarioService.BuscarPorNomeAsync(Nome);

            return Ok(usuarioBuscado);
        }
        

        
        
    }
   
}
