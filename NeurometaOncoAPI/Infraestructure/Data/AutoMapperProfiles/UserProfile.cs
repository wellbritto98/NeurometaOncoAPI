using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;

namespace NeurometaOncoAPI.Infraestructure.Data.AutoMapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDto, User>();
        CreateMap<LoginUserDto, User>();
        CreateMap<GetUserDto, User>();
        CreateMap<User, GetUserDto>();

    }

}