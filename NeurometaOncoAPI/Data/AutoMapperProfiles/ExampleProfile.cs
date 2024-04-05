using AutoMapper;
using NeurometaOncoAPI.Data.Dtos;
using NeurometaOncoAPI.Models;

namespace NeurometaOncoAPI.Data.AutoMapperProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleEntity, ExampleDto>().ReverseMap();

    }
    
}