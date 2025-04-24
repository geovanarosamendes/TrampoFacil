using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using TrampoFacil.Application.DTOs.InfoPro;
using TrampoFacil.Domain.Models;

namespace TrampoFacil.Application.Mappings
{
    public class InfoProProfile : Profile
    {
        public InfoProProfile()
        {
            
            CreateMap<InfoPro, InfoProReadDTO>();

            CreateMap<InfoProCreateDTO, InfoPro>();

            CreateMap<InfoProUpdateDTO, InfoPro>();

        }
    }
}