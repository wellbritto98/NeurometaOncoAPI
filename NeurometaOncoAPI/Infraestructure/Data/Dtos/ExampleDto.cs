using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class ExampleDto : BaseDto
{

    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }

}