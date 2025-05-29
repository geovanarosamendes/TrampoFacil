using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.InfoPro;
using TrampoFacil.Domain.Interfaces.IServices;

namespace TrampoFacil.API.Controllers
{
    public class InfoProController : ControllerBase
    {
        private readonly IInfoProService _infoProService;

        public InfoProController(IInfoProService infoProService)
        {
            _infoProService = infoProService;
        }

        //AdicionarInfoProAsync
        [HttpPost]
        [Authorize]
        public async Task<IActionResult>AdicionarInfoProAsync([FromBody] InfoProDTO infoDto)
        {
            var infoPro = await _infoProService.AdicionarInfoProAsync(infoDto);
            return Created("", infoPro);
        }

        //AtualizarInfoProAsync
        [HttpPut]
        [Authorize]
        public async Task<IActionResult>AtualizarInfoProAsync([FromBody] InfoProDTO infoDto)
        {
            var infoAtualizado = await _infoProService.AtualizarInfoProAsync(infoDto);
            return Ok(infoAtualizado);
        }

        //VisualizarInfoProAsync
        [HttpGet]
        public async Task<IActionResult>VisualizarInfoProAsync(Guid IdInfoPro)
        {
           var verInfoPro = await _infoProService.VisualizarInfoProAsync(IdInfoPro);
           return Ok(verInfoPro);
        }


        [HttpGet]
        public async Task<IActionResult> InfoProNoAnuncioAsync(Guid IdInfoPro)
        {
            var infoNoAnuncio = await _infoProService.InfoProNoAnuncioAsync(IdInfoPro);
            return Ok(infoNoAnuncio);
        }

    }
}