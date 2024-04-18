using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

namespace NeurometaOncoAPI.Infraestructure.Data;

public class DataContext : IdentityDbContext<User>
{
    //exemplo de cadastrar o DBset
    public DbSet<ExampleEntity> Examples { get; set; }
    //Adicionar para novas entidades abaixo.
  
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Psicologo> Psicologos { get; set; }
    public DbSet<Agenda> Agendas { get; set; }



    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

        
    }
}