using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;

public class Psicologo : BaseEntity.BaseEntity
{

    [Key, Column(Order = 0)]
    [ForeignKey("User")]
    public string PsicologoId {  get; set; }
    public virtual User User { get; set; }
    public string Crp { get; set; }
    public string Descricao { get; set; }
    public byte[] CarteiraCrp { get; set; }
    public virtual ICollection<Agenda> Agendas { get; set; }




}
