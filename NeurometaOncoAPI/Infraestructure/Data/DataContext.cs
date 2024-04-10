using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

namespace NeurometaOncoAPI.Infraestructure.Data;

public class DataContext : IdentityDbContext<User>
{

    public DbSet<ExampleEntity> Examples { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
}