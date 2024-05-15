using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.ApiResponse;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

namespace NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;

public interface IPsicologoRepository : IGenericRepository<Psicologo>
{
    Task<ApiResponse> GetPsicologoUser(string id);
    Task<ApiResponse> GetAllPsicologoUser();
}