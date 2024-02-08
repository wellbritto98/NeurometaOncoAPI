﻿using System.ComponentModel.DataAnnotations;

namespace SimpleApiTemplate.Data.Dtos;

public class CreateExampleDto : BaseDto
{
    
    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }
    
}