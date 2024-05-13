using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;
[PrimaryKey(nameof(PsicologoId), nameof(Data), nameof(PacienteId))]
public class Agenda : BaseEntity.BaseEntity
{

    [Column(Order = 0)]
    [ForeignKey("Psicologo")]
    public string PsicologoId {  get; set; }
    public virtual Psicologo Psicologo { get; set; }

    [Column(Order = 1)]
    public DateTime Data { get; set; }

    [Column(Order = 2)]
    [ForeignKey("Paciente")]
    public string PacienteId { get; set; }

    public virtual Paciente Paciente { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public int? Nota { get; set; }
    public string? Comentario { get; set; }



}
