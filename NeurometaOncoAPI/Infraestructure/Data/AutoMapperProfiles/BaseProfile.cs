using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<BaseEntity, Data.Dtos.BaseDto>().ReverseMap();
        CreateMap<ExampleEntity, ExampleDto>().ReverseMap();
        CreateMap<Paciente, PacienteDto>()
            .ForMember(opt => opt.User, opt => opt.MapFrom(src => src.User))
            .ReverseMap();
        CreateMap<Psicologo, PsicologoDto>()
            .ForMember(opt => opt.User, opt => opt.MapFrom(src => src.User))
            .ReverseMap();
        CreateMap<Agenda, AgendaDto>()
            .ForMember(dest => dest.Paciente, opt => opt.MapFrom(src => src.Paciente))
            .ForMember(dest => dest.Psicologo, opt => opt.MapFrom(src => src.Psicologo))
            .ReverseMap();




    }

}