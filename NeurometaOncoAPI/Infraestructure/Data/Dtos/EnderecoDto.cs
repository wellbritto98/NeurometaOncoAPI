﻿using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos;

public class EnderecoDto : BaseDto
{
    public string CEP { get; set; }
    public string Pais { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }

}