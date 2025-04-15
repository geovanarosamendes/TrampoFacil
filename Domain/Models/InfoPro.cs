

namespace Domain.Models{

    public class InfoPro{

        public Guid IdInfoPro { get; set; }
        public string Profissao { get; set; }
        public string Escolaridade { get; set; }
        public string Cursos { get; set; }
        public string Experiencias { get; set; }
        public string Habilidades { get; set; }

        public Guid UsuarioId { get; set;}
        public Usuario Usuario { get; set;}
    }
}