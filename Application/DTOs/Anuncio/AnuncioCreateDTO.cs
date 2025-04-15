namespace TrampoFacil.Application.DTOs.Anuncio{

    public class AnuncioCreateDTO{

        public required string Titulo { get; set; }
        public required string  Descricao { get; set; }
        public required string  Telefone { get; set; }
        public required string Cobranca { get; set; }

    }
}