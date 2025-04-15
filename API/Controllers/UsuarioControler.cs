using Microsoft.AspNetCore.Mvc;
using TrampoFacil.Application.DTOs.Usuario;
using TrampoFacil.Domain.Interfaces.Services;

namespace TrampoFacil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
         private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        
        // Cadastrar Usuário
        //Login
        //Atualizar dados do Perfil
        //Recuperação de Conta ("esqueci a senha")
        //Redefinir Senha
        //Logout
        //Buscar profissional por nome


        
        

        
        
    }
   
}
