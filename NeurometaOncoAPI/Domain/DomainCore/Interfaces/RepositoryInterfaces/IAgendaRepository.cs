using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

namespace NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;

public interface IAgendaRepository : IGenericRepository<Agenda>
{
    Task<List<Agenda>> GetAgendasOcupadas(string psicologoId);
    Task<List<Agenda>> GetConsultasConcluidasByPacienteId(string pacienteId);
    Task<List<Agenda>> GetConsultasConcluidasByPsicologoId(string psicologoId);
    Task<List<Agenda>> GetAgendasByPacienteId(string pacienteId);
    Task<List<Agenda>> GetAgendasByPsicologoId(string psicologoId);
}

