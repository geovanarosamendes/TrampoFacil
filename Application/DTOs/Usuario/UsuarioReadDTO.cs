// dados que você exibe no perfil ou lista

namespace TrampoFacil.Application.DTOs.Usuario{

    public class UsuarioReadDTO 
    {
        public  string? Nome { get; set; }
        public  int? Idade { get; set; }
        public  string? Cidade { get; set; }
        public  string? Bairro { get; set; }
        public string ? FotoPerfilUrl { get; set;}
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
    
}