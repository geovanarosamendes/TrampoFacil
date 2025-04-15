
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;



namespace Usuarios.Models
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

    
    public ICollecction<Anuncios> Anuncios { get; set;}
    public ICollecction<Denuncias> Denuncias { get; set;}
    public InfoProfissionais InfoProfissionais { get; set;}

    }

   
}




