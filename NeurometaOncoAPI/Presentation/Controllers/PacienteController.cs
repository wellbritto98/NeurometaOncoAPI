using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Mvc;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Paciente;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PacienteId")]
public class PacienteController : GenericController<Paciente, InsertPacienteDto, ReadPacienteDto, UpdatePacienteDto>
{
    private readonly IPacienteRepository _pacienteRepository;
    public PacienteController(IPacienteRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor, IPacienteRepository pacienteRepository) : base(repository, mapper, httpContextAccessor)
    {
        _pacienteRepository=pacienteRepository;
    }

}