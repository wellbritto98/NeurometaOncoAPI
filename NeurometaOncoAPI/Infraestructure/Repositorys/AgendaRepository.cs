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

    public async Task<List<Agenda>> GetAgendasOcupadas()
    {
        List<Agenda> agendas = await _context.Agendas.ToListAsync();
        return agendas.Where(a => a.Data > DateTime.Now).ToList();
    }

    public async Task<List<Agenda>> GetConsultasConcluidas()
    {
        return await _context.Agendas.Where(a => a.DataFim != null && a.DataInicio != null).ToListAsync();
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