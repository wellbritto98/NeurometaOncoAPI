using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class ReadAgendaDto : BaseDto
{

 
    public string? PsicologoId { get; set; }
     
    public DateTime? Data { get; set; }
     
    public string? PacienteId { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public int? Nota { get; set; }
    public string? Comentario { get; set; }
    public virtual ReadPacienteDto? Paciente { get; set; }
    public virtual ReadPsicologoDto? Psicologo { get; set; }






}