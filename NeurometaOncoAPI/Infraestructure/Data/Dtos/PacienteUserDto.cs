using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class PacienteUserDto : BaseDto
{

    [Required]
    public string PacienteId { get; set; }
    [Required]
    public int CrmMedico { get; set; }
    [Required]
    public string NomeMedico { get; set; }
    [Required]
    public string Cid { get; set; }
    [Required]
    public string UfCrm { get; set; }
    public virtual User User { get; set; }

}