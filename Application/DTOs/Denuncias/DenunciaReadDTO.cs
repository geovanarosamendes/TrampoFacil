
namespace TrampoFacil.Application.DTOs.Denuncias{        
     
     public class DenunciaReadDTO{
      public required string TituloDenuncia { get; set; }
        public required string Motivo { get; set; }
        public DateTime  CriadoEm { get; set; }
     }
}
