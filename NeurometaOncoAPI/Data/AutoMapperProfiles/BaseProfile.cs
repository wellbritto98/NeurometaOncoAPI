using AutoMapper;

namespace NeurometaOncoAPI.Data.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<Models.BaseEntity, Data.Dtos.BaseDto>().ReverseMap();
    }
    
}