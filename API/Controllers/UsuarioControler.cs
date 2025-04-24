using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.Usuario;
using TrampoFacil.Domain.Interfaces.Services;

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
        
        
        

        
        
    }
   
}
