
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace TrampoFacil.Infrastructure.Data {
 
 public class AppDbContext : DbContext
 {

    public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
    

        public DbSet<Usuario>Usuario {get; set;}
        public DbSet<InfoPro>InfoPro{get; set;}
        public DbSet<Anuncio>Anuncio {get; set;}
        public DbSet<Denuncia>Denuncia {get; set;}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        modelBuilder.Entity<Anuncio>().HasKey(a => a.IdAnuncio);
        modelBuilder.Entity<Denuncia>().HasKey(d => d.IdDenuncia);
        modelBuilder.Entity<InfoPro>().HasKey(i => i.IdInfoPro);


        
        modelBuilder.Entity<Usuario>()
            .HasMany(u=> u.Anuncios)
            .WithOne(a => a.Usuario)
            .HasForeignKey(a => a.UsuarioId);


        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Denuncias)
            .WithOne(d => d.Usuario)
            .HasForeignKey(d => d.UsuarioId);


        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.InfoPro)
            .WithOne (ip =>ip.Usuario)
            .HasForeignKey<InfoPro>(ip => ip.UsuarioId);


        
    }
    

 }

    
}