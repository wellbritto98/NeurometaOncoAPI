using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<BaseEntity, Data.Dtos.BaseDto>().ReverseMap();
    }

}