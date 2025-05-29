using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Mappings
{
    public class AutenticacaoProfile : Profile
    {

        public AutenticacaoProfile()
        {
            CreateMap<LoginDTO, Usuario>();
            CreateMap<RedefinirSenhaDTO, Usuario>();
            CreateMap<RecuperacaoDTO, Usuario>();
        }
        
        

    }
}