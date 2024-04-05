using NeurometaOncoAPI.Data;
using NeurometaOncoAPI.Models;
using NeurometaOncoAPI.Services.Interfaces;
using NeurometaOncoAPI.Services.Repositorys;
using NeurometaOncoAPI.Services.GenericRepository;

namespace NeurometaOncoAPI.Services.Repositorys;

public class ExampleRepository : GenericRepository<ExampleEntity>, IExampleRepository
{
    public ExampleRepository(DataContext context) : base(context)
    {
    }
}