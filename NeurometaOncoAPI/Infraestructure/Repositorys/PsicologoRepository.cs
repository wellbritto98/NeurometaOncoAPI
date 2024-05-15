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

    public async Task<ApiResponse> GetPsicologoUser(string id)
    {
        try
        {
            var psicologo = await _context.Psicologos.Include(x => x.User).FirstOrDefaultAsync(x => x.PsicologoId == id);
            var psicologoDto = _mapper.Map<PsicologoUserDto>(psicologo);
            return new ApiResponse { Data = psicologoDto, Message = "Psicologo encontrado com sucesso", Success = true };
        }
        catch (Exception ex)
        {
            return new ApiResponse { Data = null, Message = ex.Message, Success = false };
        }
    }

    public async Task<ApiResponse> GetAllPsicologoUser()
    {
        try
        {
            var psicologos = await _context.Psicologos.Include(x => x.User).ToListAsync();
            var psicologosDto = _mapper.Map<List<PsicologoUserDto>>(psicologos);
            return new ApiResponse { Data = psicologosDto, Message = "Psicologos encontrados com sucesso", Success = true };
        }
        catch (Exception ex)
        {
            return new ApiResponse { Data = null, Message = ex.Message, Success = false };
        }
    }
}