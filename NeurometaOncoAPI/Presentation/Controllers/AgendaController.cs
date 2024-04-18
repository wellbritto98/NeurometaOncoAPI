using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Microsoft.AspNetCore.Mvc;

namespace NeurometaOncoAPI.Presentation.Controllers;

public class AgendaController : GenericController<Agenda, AgendaDto>
{
    protected readonly IAgendaRepository _repository;
    protected readonly IMapper _mapper;
    public AgendaController(IAgendaRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet("AgendasIndisponiveis")]
    public async Task<IActionResult> GetAgendasOcupadas()
    {
        try
        {
            List<Agenda> agendas = await _repository.GetAgendasOcupadas();
            var agendasDto = _mapper.Map<List<AgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("ConsultasConcluidas")]
    public async Task<IActionResult> GetConsultasConcluidas()
    {
        try
        {
            List<Agenda> agendas = await _repository.GetConsultasConcluidas();
            var agendasDto = _mapper.Map<List<AgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}