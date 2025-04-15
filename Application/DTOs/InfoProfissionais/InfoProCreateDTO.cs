
namespace TrampoFacil.Application.DTOs.InfoProfissionais{

    public class InfoCreateDTO
    {
        public required string Profissao { get; set; }
        public required string Escolaridade { get; set; }
        public  string? Cursos { get; set; }
        public required string Experiencias { get; set; }
        public required string Habilidades { get; set; }
    }
}