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
        public async Task<IActionResult>CadastrarUsuario([FromBody] UsuarioCreateDTO usuarioCreateDto)
        {
                var dadosDeCadastro = await _usuarioService.CadastrarUsuarioAsync(usuarioCreateDto);

                return Created("", dadosDeCadastro);

        }

        [Authorize]
        [HttpPut]
         public async Task<IActionResult>AtualizarPerfil([FromBody] UsuarioUpdateDTO usuarioUpdateDto)
        {
            var usuarioAtualizado = await _usuarioService.AtualizarPerfilAsync(usuarioUpdateDto);
            return Ok(usuarioAtualizado);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult>DeletarUsuario()
        {
            var idUsuario = UsuarioHelper.ObterIdUsuarioLogado(HttpContext);

            await _usuarioService.DeletarUsuarioAsync(idUsuario);
            return NoContent();
        }

        [Authorize]
        [HttpGet("{IdUsuario}")]
        public async Task<IActionResult>VisualizarPerfil(Guid IdUsuario)
        {
            var verUsuario = await  _usuarioService.VisualizarPerfilAsync(IdUsuario);
            return Ok(verUsuario);
        }

        [Authorize]
        [HttpGet("buscar")]
        public async Task<IActionResult>BuscarPorNome([FromQuery] string Nome)
        {
            var usuarioBuscado = await _usuarioService.BuscarPorNomeAsync(Nome);

            return Ok(usuarioBuscado);
        }
        

        
        
    }
   
}
