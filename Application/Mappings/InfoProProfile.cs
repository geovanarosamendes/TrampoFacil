using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.InfoPro;

namespace TrampoFacil.Application.Mappings
{
    public class InfoProProfile : Profile
    {
        public InfoProProfile()
        {
            
            CreateMap<InfoPro, InfoProReadDTO>();

            CreateMap<InfoProDTO, InfoPro>();

            

        }
    }
}