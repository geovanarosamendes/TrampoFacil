using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.Anuncio;
using TrampoFacil.Application.Services;
using TrampoFacil.Domain.Interfaces.IServices;

namespace TrampoFacil.API.Controllers
{
    [ApiController]
    [Route("api/anuncio")]

    public class AnuncioController : ControllerBase
    {
        private readonly IAnuncioService _anuncioService;

        public  AnuncioController(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }
        
        
        //CriarAnuncioAsync
        [HttpPost]
        [Authorize]
        public async Task<IActionResult>CriarAnuncioAsync([FromBody] AnuncioDTO anuncioDto)
        {
            var anuncioCriado = await _anuncioService.CriarAnuncioAsync(anuncioDto);

            return Created ("", anuncioCriado);
        }

         //EditarAnuncioAsync
        [HttpPut]
        [Authorize]
        public async Task<IActionResult>EditarAnuncioAsync([FromBody]AnuncioDTO anuncioDto)
        {
            var anuncioUpdate = await _anuncioService.EditarAnuncioAsync(anuncioDto);

            return Created("", anuncioUpdate);
        }

        //VisualizarAnuncioAsync
        [HttpGet("id-anuncio")]
        public async Task<IActionResult>VisualizarAnuncioAsync(Guid IdAnuncio)
        {
            var verAnuncio = await _anuncioService.VisualizarAnuncioAsync(IdAnuncio);
            return Ok(verAnuncio);

        }


         //DeletarAnuncioAsync
        [Authorize]
        [HttpDelete]
        public async Task<NoContentResult> DeletarAnuncioAsync(Guid IdAnuncio)
        {
             await _anuncioService.DeletarAnuncioAsync(IdAnuncio);
             return NoContent();

        }


        //BuscarPorTituloAsync
        [HttpGet("buscar")]
        public async Task<IActionResult>BuscarPorTituloAsync(string Titulo)
        {
            var tituloAnuncio = await _anuncioService.BuscarPorTituloAsync(Titulo);
            return Ok(tituloAnuncio);
        }

        [HttpGet]
        public async Task<IActionResult>ListarTodosAnunciosAsync()
        {
           var anuncio = await _anuncioService.ListarTodosAnunciosAsync();
           return Ok(anuncio);
        }

       
        


    }
}