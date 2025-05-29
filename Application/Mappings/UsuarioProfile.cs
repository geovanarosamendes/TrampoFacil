using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.Usuario;


namespace TrampoFacil.Application.Mappings
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioReadDTO>();

            CreateMap<UsuarioDTO, Usuario>();
            
            CreateMap<UsuarioDTO, Usuario>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}