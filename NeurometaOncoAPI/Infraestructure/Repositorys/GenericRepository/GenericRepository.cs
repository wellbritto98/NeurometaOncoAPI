using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;
using NeurometaOncoAPI.Infraestructure.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SendGrid.Helpers.Mail;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly DataContext _context;

    public GenericRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> FindAsync(string json)
    {
        try
        {
            // Deserializar o JSON para um objeto Dictionary
            var filters = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            // Iniciar a consulta
            var query = _context.Set<T>().AsQueryable();

            // Obter as propriedades virtuais da entidade
            var virtualProperties = GetVirtualFields(typeof(T));

            // Iterar sobre o dicionário e construir a consulta
            foreach (var filter in filters)
            {
                // Dividir a chave em campo e operador
                var parts = filter.Key.Split('@');
                var field = parts[0];
                var operador = parts[1];

                // Converter o valor para o tipo correto
                var value = Convert.ChangeType(filter.Value.Split('@')[0], Type.GetType(filter.Value.Split('@')[1]));

                // Construir a consulta com base no operador
                switch (operador)
                {
                    case "equal":
                        query = query.Where(e => EF.Property<object>(e, field).Equals(value));
                        break;
                    case "diferente":
                        query = query.Where(e => !EF.Property<object>(e, field).Equals(value));
                        break;
                    case "maior":
                        query = query.Where(e => EF.Property<IComparable>(e, field).CompareTo(value) > 0);
                        break;
                    case "menor":
                        query = query.Where(e => EF.Property<IComparable>(e, field).CompareTo(value) < 0);
                        break;
                    case "maiorigual":
                        query = query.Where(e => EF.Property<IComparable>(e, field).CompareTo(value) >= 0);
                        break;
                    case "menorigual":
                        query = query.Where(e => EF.Property<IComparable>(e, field).CompareTo(value) <= 0);
                        break;
                }
            }

            // Adicionar includes para propriedades virtuais
            foreach (var property in virtualProperties)
            {
                query = IncludeNestedProperties(query, property);
            }

            // Executar a consulta e retornar o resultado
            return await query.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    private IQueryable<T> IncludeNestedProperties<T>(IQueryable<T> query, PropertyInfo property, string currentPath = null) where T : class
    {
        // Verificar se a propriedade é virtual, se é uma classe e não é uma string
        if (property.GetMethod.IsVirtual && property.PropertyType.IsClass && property.PropertyType != typeof(string))
        {
            // Construir o caminho de inclusão
            var includePath = currentPath != null ? $"{currentPath}.{property.Name}" : property.Name;

            // Adicionar o include para a propriedade atual usando lambda-based include
            query = query.Include(includePath);

            // Recursivamente adicionar includes para propriedades virtuais dentro desta propriedade
            var nestedVirtualProperties = property.PropertyType.GetProperties()
                .Where(p => p.GetMethod.IsVirtual && p.PropertyType.IsClass && p.PropertyType != typeof(string))
                .ToList();

            foreach (var nestedProperty in nestedVirtualProperties)
            {
                // Use lambda-based include for nested properties
                query = IncludeNestedProperties(query, nestedProperty, includePath);
            }
        }

        return query;
    }


    private List<PropertyInfo> GetVirtualFields(Type entityType)
    {
        var entityProperties = entityType.GetProperties();

        var virtualProperties = entityProperties
            .Where(p => p.GetMethod.IsVirtual && p.PropertyType.IsClass)
            .ToList();

        // Remove ICollection properties
        virtualProperties.RemoveAll(p => p.PropertyType.GetInterfaces()
            .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>)));

        return virtualProperties;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        try
        {
            var entityType = _context.Model.FindEntityType(typeof(T));
            var virtualProperties = GetVirtualFields(typeof(T));

            if (virtualProperties.Count == 0)
            {
                // fazer apenas o ToListAsync
                return await _context.Set<T>().ToListAsync();
            }
            else
            {
                // Para cada atributo virtual que seja uma classe,
                // adicionar includes para carregar os dados relacionados
                var query = _context.Set<T>().AsQueryable();
                foreach (var property in virtualProperties)
                {
                    query = IncludeNestedProperties(query, property);
                }
                return await query.ToListAsync();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<T> GetByIdAsync(params object[] keyValues)
    {
        try
        {
            var entityType = _context.Model.FindEntityType(typeof(T));
            var keyProperties = entityType.FindPrimaryKey().Properties;
            var virtualProperties = GetVirtualFields(typeof(T));

            var query = _context.Set<T>().AsQueryable();

            if (virtualProperties.Count > 0)
            {
                foreach (var property in virtualProperties)
                {
                    query = IncludeNestedProperties(query, property);
                }
            }

            // Adicionar cláusula WHERE para as chaves primárias
            for (int i = 0; i < keyProperties.Count; i++)
            {
                var keyName = keyProperties[i].Name;
                // Converter o valor da chave primária para o tipo correto
                var keyValue = Convert.ChangeType(keyValues[i], keyProperties[i].ClrType);
                query = query.Where(e => EF.Property<object>(e, keyName).Equals(keyValue));
            }

            return await query.FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
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