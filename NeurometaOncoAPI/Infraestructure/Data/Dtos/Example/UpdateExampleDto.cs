using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class UpdateExampleDto : BaseDto
{


    public string Name { get; set; }

    public string Nickname { get; set; }

}