using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;

namespace NeurometaOncoAPI.Presentation.Controllers;

public class ExampleController : GenericController<ExampleEntity, ExampleDto>
{
    public ExampleController(IExampleRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {

    }

}