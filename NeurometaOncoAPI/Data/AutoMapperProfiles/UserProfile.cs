using AutoMapper;
using NeurometaOncoAPI.Data.Dtos;
using NeurometaOncoAPI.Models;

namespace NeurometaOncoAPI.Data.AutoMapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDto, User>();
        CreateMap<LoginUserDto, User>();

    }
    
}