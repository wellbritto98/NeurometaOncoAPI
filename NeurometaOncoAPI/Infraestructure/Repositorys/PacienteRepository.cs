using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using NeurometaOncoAPI.Infraestructure.Data;

namespace NeurometaOncoAPI.Infraestructure.Repositorys;

public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
{
    public PacienteRepository(DataContext context) : base(context)
    {
    }
}