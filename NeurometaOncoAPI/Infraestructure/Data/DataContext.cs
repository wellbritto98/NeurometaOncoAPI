using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;
using System.Text;

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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Seeding a  'Administrator' role to AspNetRoles table
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Paciente", NormalizedName = "PACIENTE".ToUpper() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = "Psicologo", NormalizedName = "PSICOLOGO".ToUpper() });


        //a hasher to hash the password before seeding the user to the db
        var hasher = new PasswordHasher<IdentityUser>();

        for (int i = 1; i <= 12; i++)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(), // primary key
                UserName = $"user{i}",
                NormalizedUserName = $"USER{i}",
                Email = $"user{i}@example.com",
                NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password@123"),
                SecurityStamp = string.Empty,
                Nome = $"User {i}",
                RegisteredAt = DateTime.Now,
                DataNascimento = new DateTime(1980, 1, 1),
                EnderecoCompleto = $"Endereço {i}",
                role = i <= 6 ? "Psicologo" : "Paciente",
                FotoPerfil = Convert.FromBase64String("aHR0cHM6Ly9zdGF0aWMudmVjdGVlenkuY29tL3N5c3RlbS9yZXNvdXJjZXMvcHJldmlld3MvMDA5LzM5Ny84MzUvbm9uXzJ4L21hbi1hdmF0YXItY2xpcGFydC1pbGx1c3RyYXRpb24tZnJlZS1wbmcucG5n")
            };

            modelBuilder.Entity<User>().HasData(user);

            if (i <= 6)
            {
                var psicologo = new Psicologo
                {
                    PsicologoId = user.Id,
                    Crp = $"CRP-{i}",
                    Descricao = $"Psicologo {i}",
                    CarteiraCrp = Encoding.UTF8.GetBytes($"Carteira CRP {i}")
                };

                modelBuilder.Entity<Psicologo>().HasData(psicologo);
            }
            else
            {
                var paciente = new Paciente
                {
                    PacienteId = user.Id,
                    CrmMedico = i,
                    NomeMedico = $"Medico {i}",
                    Cid = $"CID-{i}",
                    UfCrm = $"UF-{i}",
                    FotoRgFrente = Encoding.UTF8.GetBytes($"Foto RG Frente {i}"),
                    FotoRgVerso = Encoding.UTF8.GetBytes($"Foto RG Verso {i}"),
                    ComprovanteResidencia = Encoding.UTF8.GetBytes($"Comprovante Residencia {i}"),
                    RelatorioMedico = Encoding.UTF8.GetBytes($"Relatorio Medico {i}"),
                    PDFFormatado = Encoding.UTF8.GetBytes($"PDF Formatado {i}")
                };

                modelBuilder.Entity<Paciente>().HasData(paciente);
            }

            string roleId = i <= 6 ? "2c5e174e-3b0e-446f-86af-483d56fd7212" : "2c5e174e-3b0e-446f-86af-483d56fd7211"; // Psicologo ou Paciente

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = user.Id
                }
            );
        }


    }
}