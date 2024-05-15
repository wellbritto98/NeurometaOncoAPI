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
        var random = new Random();
        var especialidades = new[] { "Psicanálise", "Terapia Cognitivo Comportamental", "Terceira Especialidade" };

        //Seeding a  'Administrator' role to AspNetRoles table
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Paciente", NormalizedName = "PACIENTE".ToUpper() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = "Psicologo", NormalizedName = "PSICOLOGO".ToUpper() });
        List<string> psicologosIds = new List<string>();
        List<string> pacientesIds = new List<string>();

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
                FotoPerfil = "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png"
            };

            modelBuilder.Entity<User>().HasData(user);

            if (i <= 6)
            {
                var psicologo = new Psicologo
                {
                    PsicologoId = user.Id,
                    Crp = $"CRP-{i}",
                    Especialidade = especialidades[random.Next(especialidades.Length)],
                    Descricao = $"Psicologo {i}",
                    CarteiraCrp = Encoding.UTF8.GetBytes($"Carteira CRP {i}")
                };

                modelBuilder.Entity<Psicologo>().HasData(psicologo);
                psicologosIds.Add(user.Id);


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
                pacientesIds.Add(user.Id);

                for (int j = 0; j < 3; j++)
                {
                    var agenda = new Agenda
                    {
                        PsicologoId = psicologosIds[i - 7], // Assume que o primeiro psicólogo está disponível
                        Data = DateTime.Now.AddDays(j - 1), // Cria uma agenda no passado e duas no futuro
                        PacienteId = user.Id,
                        DataInicio = j == 0 ? DateTime.Now.AddDays(j - 1).AddHours(j) : (DateTime?)null, // Adiciona um intervalo de 60 minutos entre as agendas
                        DataFim = j == 0 ? DateTime.Now.AddDays(j - 1).AddHours(j + 1) : (DateTime?)null, // A agenda dura 1 hora
                        Nota = j == 0 ? 10 : (int?)null, // Nota para a consulta que já ocorreu
                        Comentario = j == 0 ? "Consulta concluída" : null // Comentário para a consulta que já ocorreu
                    };

                    modelBuilder.Entity<Agenda>().HasData(agenda);
                }

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