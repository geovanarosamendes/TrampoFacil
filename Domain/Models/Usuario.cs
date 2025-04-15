
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;



namespace Domain.Models
{
    public class Usuario{

    public Guid IdUsuario {get; set;}
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string SenhaHash { get; set; }
    public string Login{ get; set; }
    public DateTime CriadoEm { get; set; }  

    
    public ICollection<Anuncio> Anuncios { get; set;}
    public ICollection<Denuncia> Denuncias { get; set;}
    public InfoPro InfoPro { get; set;}

    }

   
}




