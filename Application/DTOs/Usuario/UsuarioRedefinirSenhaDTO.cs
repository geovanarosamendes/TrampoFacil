//redefinir a senha após validação do token/código recebido.

namespace TrampoFacil.Application.DTOs.Usuario{
    
    public class UsuarioRedefinirSenhaDTO
    {
        public required string Token { get; set; }
        public required string NovaSenha { get; set; }
    }
    
}