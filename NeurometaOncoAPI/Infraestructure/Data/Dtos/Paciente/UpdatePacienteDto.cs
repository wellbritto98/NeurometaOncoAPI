using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class UpdatePacienteDto : BaseDto
{

    public string? PacienteId { get; set; }
   
    public byte[]? FotoRgFrente { get; set; }
  
    public byte[]? FotoRgVerso { get; set; }
 
    public byte[]? ComprovanteResidencia { get; set; }
 
    public byte[]? RelatorioMedico { get; set; }
 
    public byte[]? PDFFormatado { get; set; }
   
    public int? CrmMedico { get; set; }
    
    public string? NomeMedico { get; set; }
   
    public string? Cid { get; set; }
    public string? UfCrm { get; set; }

}