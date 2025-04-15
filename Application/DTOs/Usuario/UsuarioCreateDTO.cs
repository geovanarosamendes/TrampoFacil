//Cadastrar usuario

namespace TrampoFacil.Application.DTOs.Usuario{
    public class UsuarioCreateDTO 
    {
        public required string Nome { get; set; }
        public required int Idade { get; set; }
        public required string Cidade { get; set; }
        public required string Bairro { get; set; }
        public string? Email { get; set; }
        public required string Telefone { get; set; }
        public required string Login{ get; set; }
        public required string SenhaHash{ get; set; }
        
    }
}