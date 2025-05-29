using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.Denuncias;

namespace TrampoFacil.Application.Mappings
{
    public class DenunciaProfile : Profile
    {
        public DenunciaProfile()
        {
            //DTO -> Entidade 
            CreateMap<DenunciaDTO, Denuncia>();


            //Entidade -> DTO 
            CreateMap<Denuncia, DenunciaReadDTO>();

            CreateMap<Denuncia, DenunciaTituloDTO>();
        }
    }
}