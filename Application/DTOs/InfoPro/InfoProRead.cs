
namespace TrampoFacil.Application.DTOs.InfoPro{

    public class InfoProReadDTO
    {
        public string ? FotoPerfilUrl { get; set;}
        public  string? Nome { get; set; }
         public  int? Idade { get; set; }
        public required string Profissao { get; set; }
        public required string Habilidades { get; set; }
        public string? Telefone { get; set; }
        public required string Escolaridade { get; set; }
        public  string? Cursos { get; set; }
        public required string Experiencias { get; set; }
        public  string? Cidade { get; set; }
        public  string? Bairro { get; set; }
        public string? Email { get; set; }
        
    }
}