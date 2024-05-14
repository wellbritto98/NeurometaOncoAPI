using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Swashbuckle.AspNetCore.Annotations;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PacienteId")]
public class PacienteController : GenericController<Paciente, PacienteDto>
{
    public PacienteController(IPacienteRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {

    }

}