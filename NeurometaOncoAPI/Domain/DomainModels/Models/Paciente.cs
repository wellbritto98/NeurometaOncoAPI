﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;

public class Paciente : BaseEntity.BaseEntity
{

    [Key]
    [ForeignKey("User")]
    public string UserId {  get; set; }
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

}
