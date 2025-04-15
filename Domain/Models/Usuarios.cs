
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;



namespace Usuarios.Models
{
    public class Usuario{

    public int IdUsuario {get; set;}
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string SenhaHash { get; set; }
    public string Login{ get; set; }
    public DateTime CriadoEm { get; set; }  
    
    }

   
}




//Usuario 1:n Anuncios
//Usuario 1:n Denuncias
//usuario 1 Dados Profissionais