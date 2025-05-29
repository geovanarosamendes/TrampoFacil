
namespace Domain.Models{

    public class Denuncia{
        public Guid  IdDenuncia { get; set; }
        public required string TituloDenuncia { get; set; }
        public required string Motivo { get; set; }
        public DateTime  CriadoEm { get; set; }



        public Guid UsuarioId { get; set;}
        public Usuario Usuario  { get; set; }
    }
}