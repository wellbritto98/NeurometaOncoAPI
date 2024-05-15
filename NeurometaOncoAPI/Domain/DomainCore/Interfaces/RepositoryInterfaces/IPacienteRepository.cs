using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.ApiResponse;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

namespace NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;

public interface IPacienteRepository : IGenericRepository<Paciente>
{

    Task<ApiResponse> GetPacienteUser(string id);
    Task<ApiResponse> GetAllPacienteUser();

}