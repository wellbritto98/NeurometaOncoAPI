using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos.Psicologo;

public class InsertPsicologoDto : BaseDto
{

    [Required]
    public string PsicologoId { get; set; }
    [Required]
    public string Crp { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public string Especialidade { get; set; }
    [Required]
    public byte[] CarteiraCrp { get; set; }




}