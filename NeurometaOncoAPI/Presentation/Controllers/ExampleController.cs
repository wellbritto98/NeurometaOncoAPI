using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Example;

namespace NeurometaOncoAPI.Presentation.Controllers;

public class ExampleController : GenericController<ExampleEntity, InsertExampleDto, InsertExampleDto, InsertExampleDto>
{
    public ExampleController(IExampleRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {

    }

}