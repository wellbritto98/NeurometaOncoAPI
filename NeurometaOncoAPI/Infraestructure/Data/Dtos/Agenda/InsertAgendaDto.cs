using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Paciente;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos.Agenda;

public class InsertAgendaDto : BaseDto
{

    [Required]
    public string PsicologoId { get; set; }
    [Required]
    public DateTime Data { get; set; }
    [Required]
    public string PacienteId { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public int? Nota { get; set; }
    public string? Comentario { get; set; }
    public virtual InsertPacienteDto? Paciente { get; set; }
    public virtual InsertPsicologoDto? Psicologo { get; set; }






}