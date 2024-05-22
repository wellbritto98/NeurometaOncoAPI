using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class ReadPsicologoDto : BaseDto
{

   
    public string? PsicologoId { get; set; }
    
    public string? Crp { get; set; }
    
    public string? Descricao { get; set; }
   
    public string? Especialidade{ get; set; }

    public byte[]? CarteiraCrp { get; set; }
    public virtual GetUserDto? User { get; set; }



}