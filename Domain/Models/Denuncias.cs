
namespace Denuncias.Models{

    public class Denuncia{
        public int  id_denuncia { get; set; }
        public required string Motivo { get; set; }
        public int  Qtd_denuncia { get; set; }
        public DateTime  CriadoEm { get; set; }
    }
}