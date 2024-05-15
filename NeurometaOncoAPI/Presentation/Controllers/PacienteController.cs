using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Mvc;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PacienteId")]
public class PacienteController : GenericController<Paciente, PacienteDto>
{
    private readonly IPacienteRepository _pacienteRepository;
    public PacienteController(IPacienteRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor, IPacienteRepository pacienteRepository) : base(repository, mapper, httpContextAccessor)
    {
        _pacienteRepository=pacienteRepository;
    }

}