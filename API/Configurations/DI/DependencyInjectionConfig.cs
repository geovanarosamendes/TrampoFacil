using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using TrampoFacil.Domain.Interfaces.Repository;
using TrampoFacil.Domain.Interfaces.Services;
using TrampoFacil.Infrastructure.Repository;
using TrampoFacil.Application.Services;


public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        // Falta criar as injeções de dependência das outras entidades:
        
        //anuncios
        //denuncias
        //infoProfissionais
        return services;
    }
    
}