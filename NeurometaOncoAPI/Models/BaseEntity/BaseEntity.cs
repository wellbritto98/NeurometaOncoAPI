using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Models;

public abstract class BaseEntity
{
    [Key]
    [Required]
    public int Id { get; set; }
}
