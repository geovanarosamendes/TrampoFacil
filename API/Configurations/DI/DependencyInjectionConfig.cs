using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using TrampoFacil.Domain.Interfaces.IRepository;
using TrampoFacil.Domain.Interfaces.IServices;
using TrampoFacil.Infrastructure.Repository;
using TrampoFacil.Application.Services;


public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

    
        services.AddScoped<IAnuncioService, AnuncioService>();
        services.AddScoped<IAnuncioRepository, AnuncioRepository>();
        

        services.AddScoped<IDenunciaService, DenunciaService>();
        services.AddScoped<IDenunciaRepository, DenunciaRepository>();


        services.AddScoped<IInfoProService, InfoProService>();
        services.AddScoped<IInfoProRepository, InfoProRepository>();


        services.AddScoped<IAutenticacaoService, AutenticacaoService>();
        services.AddScoped<IAutenticacaoRepository, AutenticacaoRepository>();


        return services;
    }
    
}