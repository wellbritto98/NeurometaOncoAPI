using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class ReadExampleDto : BaseDto
{


    public string Name { get; set; }

    public string Nickname { get; set; }

}