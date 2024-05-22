using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using NeurometaOncoAPI.Infraestructure.Data;
using NeurometaOncoAPI.Domain.DomainModels.Models.ApiResponse;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;
using AutoMapper;

namespace NeurometaOncoAPI.Infraestructure.Repositorys;

public class PsicologoRepository : GenericRepository<Psicologo>, IPsicologoRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public PsicologoRepository(DataContext context, IMapper mapper) : base(context)
    {
        _context = context;
        _mapper = mapper;
    }

  
}