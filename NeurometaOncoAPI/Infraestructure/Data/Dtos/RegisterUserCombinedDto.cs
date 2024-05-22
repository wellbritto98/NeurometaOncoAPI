

using AuthDtos = NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth;
using Models = NeurometaOncoAPI.Domain.DomainModels.Models;
using Dtos = NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos
{
    public class RegisterUserCombinedDto
    {
        public AuthDtos.RegisterUserDto RegisterUser { get; set; }
        public Dtos.Paciente.CreatePacienteDto? Paciente { get; set; }
        public Dtos.Psicologo.CreatePsicologoDto? Psicologo { get; set; }
    }
}
