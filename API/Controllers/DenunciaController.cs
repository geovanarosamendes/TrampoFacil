using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.Denuncias;
using TrampoFacil.Domain.Interfaces.IServices;

namespace TrampoFacil.API.Controllers
{
    public class DenunciaController : ControllerBase
    {
        private readonly IDenunciaService _denunciaService;

        public DenunciaController(IDenunciaService denunciaService)
        {
            _denunciaService = denunciaService;
        }

        
        [HttpPost]
        public async Task<IActionResult>CriarDenunciaAsync([FromBody] DenunciaDTO denunciaDto)
        {
            var denuncia = await _denunciaService.CriarDenunciaAsync(denunciaDto);
            return Created("", denuncia);
        }

        
        [HttpGet]
        [Authorize]
        public async Task<IActionResult>VerDenunciaAsync(Guid IdDenuncia)
        {
           var verDenuncia = await _denunciaService.VerDenunciasAsync(IdDenuncia);
           return Ok(verDenuncia);    
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult>ListarDenunciasAsync()
        {
            var listaDenuncia = await _denunciaService.ListarDenunciasAsync();
            return Ok(listaDenuncia);
        }

    }
}