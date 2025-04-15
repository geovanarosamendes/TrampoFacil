
using Microsoft.EntityFrameworkCore;
using Anuncio.Models;
using Usuario.Models;
using Denuncia.Models;
using InfoPro.Models;

namespace TrampoFacil.Infrastructure.Data {
 
 public class AppDbContext : DbContext
 {

    public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
    

        public DbSet<Usuario>Usuario {get; set;}
        public DbSet<InfoPro>DadosPro{get; set;}
        public DbSet<Anuncio>Anuncio {get; set;}
        public DbSet<Denuncia>Denuncia {get; set;}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Usuarios 1:N Anuncios
        modelBuilder.Entity<Usuario>()
            .HasMany(u=> u.Anuncios)
            .WithOne(a => a.Usuario)
            .HasForeignKey(a => a.UsuarioId);


        //Usuarios 1:N Denuncias
        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Denuncias)
            .WithOne(d => d.Usuario)
            .HasForeignKey(d => d.UsuarioId);


        //Usuarios 1:1 InfoProfissionais
        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.InfoProf)
            .WithOne (ip =>ip.Usuario)
            .HasForeignKey<InfoPro>(ip => ip.UsuarioId);
    }
    

 }

    
}