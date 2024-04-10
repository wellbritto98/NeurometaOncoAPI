using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleEntity, ExampleDto>().ReverseMap();

    }

}