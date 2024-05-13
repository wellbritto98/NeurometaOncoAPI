using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Infraestructure.Data;
using Newtonsoft.Json;

namespace NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly DataContext _context;

    public GenericRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(params Object[] keyValues)
    {
        return await _context.Set<T>().FindAsync(keyValues);
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<int> UpdateAsync(T entity)
    {
        try
        {
            _context.Entry(entity).State = EntityState.Modified;
            var updatedEntity = await _context.SaveChangesAsync();
            return updatedEntity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public async Task DeleteAsync(params object[] keyValues)
    {
        var entity = await _context.Set<T>().FindAsync(keyValues);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}