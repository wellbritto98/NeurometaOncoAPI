using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Mvc;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PsicologoId")]
public class PsicologoController : GenericController<Psicologo, InsertPsicologoDto, ReadPsicologoDto, UpdatePsicologoDto>
{
    private readonly IPsicologoRepository _psicologoRepository;

    public PsicologoController(IPsicologoRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {
        _psicologoRepository = repository;
    }


}