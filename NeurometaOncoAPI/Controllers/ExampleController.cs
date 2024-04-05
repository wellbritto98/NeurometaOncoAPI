using AutoMapper;
using NeurometaOncoAPI.Data.Dtos;
using NeurometaOncoAPI.Models;
using NeurometaOncoAPI.Controllers.GenericController;
using NeurometaOncoAPI.Services.Interfaces;

namespace NeurometaOncoAPI.Controllers;

public class ExampleController : GenericController<ExampleEntity, ExampleDto>
{
    public ExampleController( IExampleRepository repository, IMapper mapper,  IHttpContextAccessor httpContextAccessor) : base( repository, mapper, httpContextAccessor)
    {
        
    }
    
}