using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;

namespace NeurometaOncoAPI.Presentation.Controllers;

public class EnderecoController : GenericController<Endereco, EnderecoDto>
{
    public EnderecoController(IEnderecoRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {
        
    }

}