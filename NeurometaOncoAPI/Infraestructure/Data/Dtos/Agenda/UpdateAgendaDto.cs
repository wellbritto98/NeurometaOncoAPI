using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class UpdateAgendaDto : BaseDto
{
    
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public int? Nota { get; set; }
    public string? Comentario { get; set; }

}