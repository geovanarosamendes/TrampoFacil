using AutoMapper;
using Domain.Models;
using TrampoFacil.Application.DTOs.Anuncio;

namespace TrampoFacil.Application.Mappings
{
    public class AnuncioProfile : Profile
    {
        public AnuncioProfile()
        {
            //DTO -> Entidade 
            CreateMap<AnuncioDTO, Anuncio>();


            //Entidade -> DTO 
            CreateMap<Anuncio, AnuncioTituloDTO>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Usuario.Nome))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Usuario.Cidade));

            //Entidade -> DTO 
            CreateMap<Anuncio, AnuncioReadDTO>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Usuario.Nome))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Usuario.Cidade))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Usuario.Bairro))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Usuario.Telefone));

        }
    }
}