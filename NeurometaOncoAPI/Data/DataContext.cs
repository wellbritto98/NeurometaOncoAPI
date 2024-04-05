using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Models;

namespace NeurometaOncoAPI.Data;

public class DataContext : IdentityDbContext<User>
{
    
    public DbSet<ExampleEntity> Examples { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}