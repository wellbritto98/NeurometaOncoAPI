using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class PsicologoDto : BaseDto
{

    [Required]
    public string UserId { get; set; }
    [Required]
    public string Crp { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public byte[] CarteiraCrp { get; set; }



}