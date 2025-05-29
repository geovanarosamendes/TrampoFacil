namespace TrampoFacil.Application.DTOs.Anuncio
{
    public class AnuncioReadDTO
    {
        public required string Titulo { get; set; }
        public required string  Descricao { get; set; }
        public  string? Nome { get; set; }
         public  string? Cidade { get; set; }
         public  string? Bairro { get; set; }
        public string  Telefone { get; set; }
        public required string Cobranca { get; set; }
        public string? Valor { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}