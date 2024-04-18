using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class PacienteDto : BaseDto
{

    [Required]
    public string PacienteId { get; set; }
    [Required]
    public byte[] FotoRgFrente { get; set; }
    [Required]
    public byte[] FotoRgVerso { get; set; }
    [Required]
    public byte[] ComprovanteResidencia { get; set; }
    [Required]
    public byte[] RelatorioMedico { get; set; }
    [Required]
    public byte[] PDFFormatado { get; set; }
    [Required]
    public int CrmMedico { get; set; }
    [Required]
    public string NomeMedico { get; set; }
    [Required]
    public string Cid { get; set; }
    [Required]
    public string UfCrm { get; set; }

}