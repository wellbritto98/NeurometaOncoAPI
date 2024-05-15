using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;

public class Paciente : BaseEntity.BaseEntity
{

    [Key, Column(Order = 0)]
    [ForeignKey("User")]
    public string PacienteId {  get; set; }
    //Retornar esse cara no get,
    public virtual User User { get; set; }
    
    public byte[] FotoRgFrente { get; set; }
    public byte[] FotoRgVerso {  get; set; }
    public byte[] ComprovanteResidencia { get; set; }
    public byte[] RelatorioMedico { get; set; }
    public byte[] PDFFormatado { get; set; }
    public int CrmMedico { get; set; }
    public string NomeMedico { get; set; }
    public string Cid { get; set; }
    public string UfCrm {  get; set; }
    public virtual ICollection<Agenda> Agendas { get; set; }


}
