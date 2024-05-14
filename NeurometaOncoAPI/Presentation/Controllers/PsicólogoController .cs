using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Swashbuckle.AspNetCore.Annotations;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PsicologoId")]
public class PsicologoController : GenericController<Psicologo, PsicologoDto>
{
    public PsicologoController(IPsicologoRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {

    }

}