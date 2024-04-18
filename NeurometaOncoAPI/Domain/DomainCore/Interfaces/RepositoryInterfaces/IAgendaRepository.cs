using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

namespace NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;

public interface IAgendaRepository : IGenericRepository<Agenda>
{
    Task<List<Agenda>> GetAgendasOcupadas();
    Task<List<Agenda>> GetConsultasConcluidas();
}

