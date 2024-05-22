using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Agenda;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Paciente;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Example;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<BaseEntity, Data.Dtos.BaseDto>().ReverseMap();
        CreateMap<ExampleEntity, InsertExampleDto>().ReverseMap();
        CreateMap<ExampleEntity, ReadExampleDto>().ReverseMap();
        CreateMap<ExampleEntity, UpdateExampleDto>().ReverseMap();
        CreateMap<Paciente, ReadPacienteDto>()
            .ForMember(opt => opt.User, opt => opt.MapFrom(src => src.User))
            .ReverseMap();
        CreateMap<Psicologo, ReadPsicologoDto>()
            .ForMember(opt => opt.User, opt => opt.MapFrom(src => src.User))
            .ReverseMap();
        CreateMap<Agenda, ReadAgendaDto>()
            .ForMember(dest => dest.Paciente, opt => opt.MapFrom(src => src.Paciente))
            .ForMember(dest => dest.Psicologo, opt => opt.MapFrom(src => src.Psicologo))
            .ReverseMap();
        CreateMap<CreatePacienteDto, Paciente>().ReverseMap();
        CreateMap<CreatePsicologoDto, Psicologo>().ReverseMap();
        CreateMap<InsertAgendaDto, Agenda>().ReverseMap();
        CreateMap<UpdateAgendaDto, Agenda>().ReverseMap();
        CreateMap<ReadAgendaDto, Agenda>().ReverseMap();
        CreateMap<ReadPacienteDto, Paciente>().ReverseMap();
        CreateMap<ReadPsicologoDto, Psicologo>().ReverseMap();
        CreateMap<UpdatePacienteDto, Paciente>().ReverseMap();
        CreateMap<UpdatePsicologoDto, Psicologo>().ReverseMap();
        CreateMap<InsertPacienteDto, Paciente>().ReverseMap();
        CreateMap<InsertPsicologoDto, Psicologo>().ReverseMap();
        
        




    }

}