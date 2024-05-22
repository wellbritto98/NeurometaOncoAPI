using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Agenda;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Presentation.Controllers;

[SwaggerTag("Chaves primarias: PsicologoId, Data, PacienteId")]

public class AgendaController : GenericController<Agenda, InsertAgendaDto, ReadAgendaDto, UpdateAgendaDto>
{
    protected readonly IAgendaRepository _repository;
    protected readonly IMapper _mapper;
    public AgendaController(IAgendaRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet("AgendasIndisponiveis")]
    [SwaggerOperation(
               Summary = "Retorna uma lista de agendas ocupadas de um psicólogo"
           )]
    public async Task<IActionResult> GetAgendasOcupadas(string psicologoId)
    {
        try
        {
            List<Agenda> agendas = await _repository.GetAgendasOcupadas(psicologoId);
            var agendasDto = _mapper.Map<List<InsertAgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("AgendasPorPaciente/{pacienteId}")]
    [SwaggerOperation(
                      Summary = "Retorna uma lista de agendas de um paciente"
                  )]
    public async Task<IActionResult> GetAgendasByPacienteId(string pacienteId)
    {
        try
        {
            List<Agenda> agendas = await _repository.GetAgendasByPacienteId(pacienteId);
            var agendasDto = _mapper.Map<List<InsertAgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("AgendasPorPsicologo/{psicologoId}")]
    [SwaggerOperation(
                             Summary = "Retorna uma lista de agendas de um psicólogo"
                         )]
    public async Task<IActionResult> GetAgendasByPsicologoId(string psicologoId)
    {
        try
        {
            List<Agenda> agendas = await _repository.GetAgendasByPsicologoId(psicologoId);
            var agendasDto = _mapper.Map<List<InsertAgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }




    [HttpGet("ConsultasConcluidasPorPaciente/{pacienteId}")]
    [SwaggerOperation(
                             Summary = "Retorna uma lista de consultas concluídas de um paciente"
                         )]
    public async Task<IActionResult> GetConsultasConcluidasByPacienteId(string pacienteId)
    {
        try
        {
            List<Agenda> agendas = await _repository.GetConsultasConcluidasByPacienteId(pacienteId);
            var agendasDto = _mapper.Map<List<InsertAgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("ConsultasConcluidasPorPsicologo/{psicologoId}")]
    [SwaggerOperation(
                                    Summary = "Retorna uma lista de consultas concluídas de um psicólogo"
                                )]
    public async Task<IActionResult> GetConsultasConcluidasByPsicologoId(string psicologoId)
    {
        try
        {
            List<Agenda> agendas = await _repository.GetConsultasConcluidasByPsicologoId(psicologoId);
            var agendasDto = _mapper.Map<List<InsertAgendaDto>>(agendas);
            return Ok(agendas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}