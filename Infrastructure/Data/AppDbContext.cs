
using Microsoft.EntityFrameworkCore;
using Anuncios.Models;
using Usuarios.Models;
using Denuncias.Models;
using InfoProfissionais.Models;

namespace TrampoFacil.Infrastructure.Data {
 
 public class AppDbContext : DbContext
 {

    public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
    

        public DbSet<Usuario>Usuarios {get; set;}
        public DbSet<InfoPro>DadosProfissionais {get; set;}
        public DbSet<Anuncio>Anuncios {get; set;}
        public DbSet<Denuncia>Denuncias {get; set;}
    

 }

    
}