

namespace Anuncios.Models{

    public class Anuncio{
        public int id_anuncio { get; set; }
        public string Titulo { get; set; }
        public string  Descricao { get; set; }
        public string  Telefone { get; set; }
        public string Cobranca { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}