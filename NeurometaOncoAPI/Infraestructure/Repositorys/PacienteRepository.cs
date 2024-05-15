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

    public async Task<ApiResponse> GetPacienteUser(string id)
    {
        try
        {
            var paciente = await _context.Pacientes.Include("User").FirstOrDefaultAsync(x => x.PacienteId == id);
            var pacienteDto = _mapper.Map<PacienteUserDto>(paciente);
            return new ApiResponse { Data = pacienteDto, Message = "Paciente encontrado com sucesso", Success = true };
        }
        catch (Exception ex)
        {
            return new ApiResponse { Data = null, Message = ex.Message, Success = false };
        }
    }

    public async Task<ApiResponse> GetAllPacienteUser()
    {
        try
        {
            var pacientes = await _context.Pacientes.Include("User").ToListAsync();
            var pacientesDto = _mapper.Map<List<PacienteUserDto>>(pacientes);
            return new ApiResponse { Data = pacientesDto, Message = "Pacientes encontrados com sucesso", Success = true };
        }
        catch (Exception ex)
        {
            return new ApiResponse { Data = null, Message = ex.Message, Success = false };
        }
    }
}