using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class PsicologoUserDto : BaseDto
{


    public string PsicologoId { get; set; }
    public string Crp { get; set; }
    public string Descricao { get; set; }
    public string Especialidade { get; set; }
    public virtual User User { get; set; }


}