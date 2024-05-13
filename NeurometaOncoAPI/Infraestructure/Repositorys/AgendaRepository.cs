using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using NeurometaOncoAPI.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NeurometaOncoAPI.Infraestructure.Repositorys;

public class AgendaRepository : GenericRepository<Agenda>, IAgendaRepository
{
    private readonly DataContext _context;
    public AgendaRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Agenda>> GetAgendasOcupadas(string psicologoId)
    {
        List<Agenda> agendas = await _context.Agendas.Where(w => w.PsicologoId == psicologoId).ToListAsync();
        return agendas.Where(a => a.Data > DateTime.Now).ToList();
    }

    public async Task<List<Agenda>> GetConsultasConcluidasByPacienteId(string pacienteId)
    {
        return await _context.Agendas.Where(a => a.DataFim != null && a.DataInicio != null && a.PacienteId == pacienteId).ToListAsync();
    }

    public async Task<List<Agenda>> GetConsultasConcluidasByPsicologoId(string psicologoId)
    {
        return await _context.Agendas.Where(a => a.DataFim != null && a.DataInicio != null && a.PacienteId == psicologoId).ToListAsync();
    }

    public async Task<List<Agenda>> GetAgendasByPacienteId(string pacienteId)
    {
        return await _context.Agendas.Where(a => a.PacienteId == pacienteId).ToListAsync();
    }

    public async Task<List<Agenda>> GetAgendasByPsicologoId(string psicologoId)
    {
        return await _context.Agendas.Where(a => a.PsicologoId == psicologoId).ToListAsync();
    }


    public async override Task<Agenda> AddAsync(Agenda entity)
    {
        try
        {
            if (entity.Data < DateTime.Now)
            {
                throw new Exception("Não é possível agendar para datas passadas.");
            }
            await _context.Agendas.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}