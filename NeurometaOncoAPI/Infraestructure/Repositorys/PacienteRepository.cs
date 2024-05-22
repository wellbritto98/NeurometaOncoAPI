using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using NeurometaOncoAPI.Infraestructure.Data;
using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models.ApiResponse;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Infraestructure.Repositorys;

public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public PacienteRepository(DataContext context, IMapper mapper) : base(context)
    {

        _context = context;
        _mapper = mapper;
    }

 
}