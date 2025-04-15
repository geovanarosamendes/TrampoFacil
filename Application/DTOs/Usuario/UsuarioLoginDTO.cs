//Fazer Login

namespace TrampoFacil.Application.DTOs.Usuario{
    public class UsuarioLoginDTO
    {
        public required string Login { get; set; }
        public required string SenhaHash { get; set; }
    }
}