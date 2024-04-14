using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<BaseEntity, Data.Dtos.BaseDto>().ReverseMap();
        CreateMap<ExampleEntity, ExampleDto>().ReverseMap();
        CreateMap<Endereco, EnderecoDto>().ReverseMap();

    }

}