using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeurometaOncoAPI.Presentation.Controllers.GenericController;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GenericController<T1, T2> : ControllerBase where T1 : BaseEntity where T2 : class
{
    private readonly IGenericRepository<T1> _repository;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GenericController(IGenericRepository<T1> repository, IMapper mapper,
        IHttpContextAccessor httpContextAccessor)
    {
        _repository = repository;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpGet("GetAll")]
    [Authorize]
    public async Task<ActionResult<IEnumerable<T2>>> GetAll()
    {
        var entities = await _repository.GetAllAsync();
        return Ok(_mapper.Map<IEnumerable<T2>>(entities));
    }

    [HttpGet("Get/{id}")]
    [Authorize]
    public async Task<ActionResult<T2>> Get(string id)
    {
        try
        {
            // Deserialize the JSON into a dictionary
            var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(id);

            // Get the primary key properties of T1 based on ColumnOrder
            var keyProperties = typeof(T1).GetProperties()
                .Where(p => p.GetCustomAttributes(typeof(ColumnAttribute), true)
                             .Cast<ColumnAttribute>()
                             .Any(ca => ca.Order >= 0)) 
                .ToList();

            // Validate that all primary key properties are present
            if (keyProperties.Any(key => !dict.ContainsKey(key.Name)))
            {
                return BadRequest("Missing primary key properties in the request.");
            }

            // Convert the values to the correct types
            var keyValues = keyProperties.Select(key =>
            {
                try
                {
                    return Convert.ChangeType(dict[key.Name], key.PropertyType);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Invalid value for property '{key.Name}': {ex.Message}");
                }
            }).ToArray();

            // Get the entity by its primary key
            var entity = await _repository.GetByIdAsync(keyValues);
            if (entity == null) return NotFound();

            return Ok(_mapper.Map<T2>(entity));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }



    [HttpPost("Create")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<T2>> Post(T2 dto)
    {
        try { 
        var entity = _mapper.Map<T1>(dto);
        var createdEntity = await _repository.AddAsync(entity);
        return Ok(_mapper.Map<T2>(createdEntity));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Update")]
    [Authorize]
    public async Task<ActionResult> Put([FromQuery] string id, T2 dto)
    {
        // Desserializa o JSON em um dicionário
        var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(id);

        // Pega os valores do dicionário e coloca em um array
        Object[] keyValues = dict.Values.ToArray();
        var entity = await _repository.GetByIdAsync(keyValues);

        var mappedEntity = _mapper.Map(dto, entity);

        await _repository.UpdateAsync(mappedEntity);
        return Ok("Atualizado com sucesso");
    }

    [HttpDelete("Delete")]
    [Authorize]
    public async Task<IActionResult> Delete([FromQuery] string id)
    {
        var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(id);

        // Pega os valores do dicionário e coloca em um array
        Object[] keyValues = dict.Values.ToArray();
        await _repository.DeleteAsync(keyValues);
        return NoContent();
    }
}