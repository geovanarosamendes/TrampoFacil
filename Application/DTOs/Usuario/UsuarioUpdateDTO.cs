//Editar perfil

namespace TrampoFacil.Application.DTOs.Usuario{
    public class UsuarioUpdateDTO{
        public Guid IdUsuario { get; set; }
        public required string Nome { get; set; }
        public required int Idade { get; set; }
        public required string Cidade { get; set; }
        public required string Bairro { get; set; }
        public string? Email { get; set; }
        public string ? FotoPerfilUrl { get; set;}
        public required string Telefone { get; set; }
        public required string Login { get; set; }

    }
}