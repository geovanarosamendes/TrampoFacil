

namespace Domain.Models{

    public class Anuncio{
        public Guid IdAnuncio { get; set; }
        public string Titulo { get; set; }
        public string  Descricao { get; set; }
        public string  Telefone { get; set; }
        public string Cobranca { get; set; }
        public string Valor { get; set; }
        public DateTime CriadoEm { get; set; }

        public Guid UsuarioId { get; set;}
        public Usuario Usuario { get; set;}

        
    }
}