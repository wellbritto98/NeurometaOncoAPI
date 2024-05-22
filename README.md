<h1>NeuroMetaOncoAPI README</h1>
<h3>### Project Under Development</h3>

<h2>Overview</h2>
<p>SimpleApiTemplate is a streamlined, efficient solution designed to accelerate the development process of CRUD (Create, Read, Update, Delete) operations in web applications. Utilizing the power of Entity Framework Core, this project simplifies data handling by implementing generic controllers and repositories. It's tailored for developers looking to minimize boilerplate code while maintaining flexibility and scalability in their projects.</p>

<h3>Features</h3>
<ul>
   <li><strong>Generic Controllers and Repositories</strong>: Facilitate rapid development of CRUD operations across different entities without the need to write repetitive code.</li>
   <li><strong>Entity Framework Core Integration</strong>: Leverages EF Core for ORM capabilities, ensuring efficient data access and manipulation.</li>
   <li><strong>Swagger/OpenAPI Support</strong>: Automatically generates API documentation, making it easier to understand and test the API endpoints.</li>
   <li><strong>Secure API Endpoints</strong>: Implements security measures including an API key scheme for authentication.</li>
   <li><strong>PostgreSQL Database Support</strong>: Configured to use PostgreSQL, providing a robust and scalable database solution.</li>
   <li><strong>AutoMapper Integration</strong>: Simplifies the task of transforming data between types, enhancing code maintainability and readability.</li>
   <li><strong>Identity Framework Integration</strong>: Supports user authentication and authorization, making it suitable for applications requiring user management.</li>
   <li><strong>Email Services</strong>.</li>
</ul>

<h3>Getting Started</h3>
<h4>Prerequisites</h4>
<ul>
   <li>.NET 8.0.1 SDK</li>
   <li>PostgreSQL Server</li>
   <li>Visual Studio Code, Visual Studio, or another compatible IDE</li>
</ul>

<h4>Setting Up</h4>
<ol>
   <li><strong>Clone the repository</strong> to your local machine.</li>
   <li><strong>Install PostgreSQL</strong></li>
   <li><strong>Update the connection string</strong> in <code>appsettings.json</code> with your PostgreSQL server details.</li>
   <li><strong>Run database migrations</strong> if necessary to set up your database schema.</li>
   <li><strong>Build and run the project</strong> using your IDE or the .NET CLI.</li>
</ol>

<h4>Using the API</h4>
<ul>
   <li>Access the Swagger UI by navigating to <code>https://localhost:&lt;port&gt;/swagger</code> in your web browser. This interface allows you to test and explore the available API endpoints.</li>
   <li>Use the provided endpoints to perform CRUD operations on your entities. The generic controller supports operations like <code>GetAll</code>, <code>Get/{id}</code>, <code>Create</code>, <code>Update/{id}</code>, and <code>Delete/{id}</code>.</li>
   <li>If you need to update any repository method or controller action, just override it. Or create a new method or action.</li>
   <li>Every new entity needs to inherit from BaseEntity, and its controller must inherit from GenericController, just as its repository must inherit from GenericRepository.</li>
</ul>

<h3>Architecture</h3>
<p>This project is structured around the following key components:</p>
<ul>
   <li><strong>DOMAIN</strong>:
      <ul>
         <li>DomainCore: Contains interfaces that define contracts for repositories and services. These interfaces are used to implement the separation of concerns and facilitate dependency injection.</li>
         <li>DomainModels: Contains the data models that represent the application's domain entities and are used in persistence operations and business logic.</li>
         <li>Services: Contains the main business logic, such as authentication (JWT) and email sending (SMTP). Here are implemented the services that use the models and repositories defined in the previous layers to perform complex operations.</li>
      </ul>
   </li>
   <li><strong>Infrastructure</strong>
      <ul>
         <li>This layer provides the implementation details for data access, mapping, and repository patterns. It serves as the foundation for interacting with the database and transforming data between different layers of the application.</li>
         <li><strong>Data</strong>
            <ul>
               <li><strong>AutoMapperProfiles</strong>: Contains mapping profiles used to configure how objects are mapped between different types (e.g., entities to DTOs).</li>
               <li><strong>Dtos</strong>: Contains Data Transfer Objects (DTOs), which are used to transfer data between different layers of the application. These objects are typically lightweight and do not contain any business logic.</li>
               <li><strong>DataContext.cs</strong>: Manages the database connection and sets up the tables and relationships for Entity Framework.</li>
            </ul>
         </li>
         <li><strong>Repositories</strong>
            <ul>
               <li>Implements the repository pattern, providing a way to abstract data access logic and perform CRUD operations. The generic repository provides a base for common operations, while specific repositories implement entity-specific logic.</li>
            </ul>
         </li>
      </ul>
   </li>
   <li><strong>Presentation</strong>
      <ul>
         <li>This layer is responsible for managing the HTTP request and response cycle. It handles client requests, delegates processing to the appropriate services or business logic, and returns the results back to the client.</li>
         <li><strong>Controllers</strong>
            <ul>
               <li><strong>GenericController</strong>: Provides common actions that can be reused by other controllers, helping to reduce code duplication and simplify maintenance.</li>
               <li><strong>Specific Controllers (AgendaController, ExampleController, PacienteController, PsicologoController)</strong>: Each of these controllers manages a specific type of entity and contains actions corresponding to the operations that can be performed on that entity (e.g., CRUD operations).</li>
            </ul>
         </li>
      </ul>
   </li>
</ul>

<h3>Conclusion</h3>
<p>This API offers a solid foundation for rapidly developing robust web applications with comprehensive CRUD functionality. By abstracting common tasks into generic components, it allows developers to focus on the unique aspects of their projects, enhancing productivity and code quality.</p>

<hr>

<h1>Quickstart</h1>

<ol>
   <li>
      <h2>Criação do DomainModel</h2>
      <pre><code>
// DomainModels/Models/Example.cs
using System.ComponentModel.DataAnnotations;
using NeurometaOncoAPI.Domain.DomainModels.Models.BaseEntity;

namespace NeurometaOncoAPI.Domain.DomainModels.Models;
public class ExampleEntity : BaseEntity.BaseEntity
{
    [Key]
    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }
    public bool IsConfirmed { get; set; }
}
      </code></pre>
   </li>
   <li>
      <h2>Criação da Interface do Repositório</h2>
      <pre><code>
// DomainCore/Interfaces/RepositoryInterfaces/IExampleRepository.cs
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;


namespace NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;

public interface IExampleRepository : IGenericRepository<'ExampleEntity>
{

}
      </code></pre>
   </li>
   <li>
      <h2>Criação do Repositório</h2>
      <pre><code>
// Infrastructure/Data/Repositories/ExampleRepository.cs
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Infraestructure.Repositorys.GenericRepository;
using NeurometaOncoAPI.Infraestructure.Data;

namespace NeurometaOncoAPI.Infraestructure.Repositorys;

public class ExampleRepository : GenericRepository<'ExampleEntity>, IExampleRepository
{
    public ExampleRepository(DataContext context) : base(context)
    {
    }
}
      </code></pre>
   </li>
   <li>
      <h2>Registrar o Repositório e a Interface no Program.cs</h2>
      <pre><code>
// Program.cs
builder.Services.AddScoped<'IExampleRepository, ExampleRepository>();
      </code></pre>
   </li>
   <li>
      <h2>Criação dos DTOs</h2>
      <pre><code>
// Infrastructure/Data/Dtos/Example/InsertExampleDto.cs
public class InsertExampleDto : BaseDto
{

    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }

}
      </code></pre>
      <pre><code>
// Infrastructure/Data/Dtos/Example/ReadExampleDto.cs
public class ReadExampleDto : BaseDto
{


    public string Name { get; set; }

    public string Nickname { get; set; }

}
      </code></pre>
      <pre><code>
// Infrastructure/Data/Dtos/Example/UpdateExampleDto.cs
public class UpdateExampleDto : BaseDto
{


    public string Name { get; set; }

    public string Nickname { get; set; }

}
      </code></pre>
   </li>
   <li>
      <h2>Registrar o Profile</h2>
      <pre><code>
// Infrastructure/Data/AutoMapperProfiles/BaseProfile.cs
        CreateMap<'ExampleEntity, InsertExampleDto>().ReverseMap();
        CreateMap<'ExampleEntity, ReadExampleDto>().ReverseMap();
        CreateMap<'ExampleEntity, UpdateExampleDto>().ReverseMap();
      </code></pre>
   </li>
   <li>
      <h2>Criação do Controller</h2>
      <pre><code>
// Presentation/Controllers/ExampleController.cs
using AutoMapper;
using NeurometaOncoAPI.Domain.DomainModels.Models;
using NeurometaOncoAPI.Domain.DomainCore.Interfaces.RepositoryInterfaces;
using NeurometaOncoAPI.Presentation.Controllers.GenericController;
using NeurometaOncoAPI.Infraestructure.Data.Dtos.Example;
using NeurometaOncoAPI.Infraestructure.Data.Dtos;

namespace NeurometaOncoAPI.Presentation.Controllers;

public class ExampleController : GenericController<ExampleEntity, InsertExampleDto, ReadExampleDto, UpdateExampleDto>
{
    public ExampleController(IExampleRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper, httpContextAccessor)
    {

    }

}
      </code></pre>
   </li>
   <li>
      <h2>Adicionar a Primeira Migração</h2>
      <pre><code>
dotnet ef migrations add firstmigration
      </code></pre>
   </li>
   <li>
      <h2>Atualizar o Banco de Dados</h2>
      <pre><code>
dotnet ef database update
      </code></pre>
   </li>
</ol>

<h2>Resultado final do quick start :</h2>
<img src="https://i.imgur.com/fh0gRp4.png"></img>

<h1>Explicação dos métodos</h1>

<ul>
   <li>
      <strong>GetAllAsync</strong>: 
      <p>Retrieves all entities of type <code>T</code> from the database. It supports dynamic inclusion of related entities using joins for properties that are virtual and class types. This method returns a list of all entities.</p>
   </li>
   <li>
      <strong>GetByIdAsync</strong>: 
      <p>Fetches a single entity by its primary key(s). This method supports entities with composite keys and includes related entities if they are virtual properties. It returns the entity that matches the provided key values.</p>
   </li>
   <li>
      <strong>FindAsync</strong>: 
      <p>Finds entities based on a dynamic filter provided as a JSON string. The filter can include various comparison operators such as equal, different, greater, less, etc., and supports nested virtual properties. This method returns a list of entities that match the filter criteria.</p>
   </li>
   <li>
      <strong>AddAsync</strong>: 
      <p>Adds a new entity to the database. This method accepts an entity of type <code>T</code>, adds it to the context, and saves the changes. It returns the added entity.</p>
   </li>
   <li>
      <strong>UpdateAsync</strong>: 
      <p>Updates an existing entity in the database. The entity is marked as modified in the context, and the changes are saved. This method returns the updated entity.</p>
   </li>
   <li>
      <strong>DeleteAsync</strong>: 
      <p>Deletes an entity from the database based on its primary key(s). This method fetches the entity using the provided key values, removes it from the context, and saves the changes.</p>
   </li>
</ul>

<h1>ConnectionStrings, JWTSecret, Email Key</h1>

<p>During development, the application uses the <code>appsettings.json</code> file to store connection strings, JWT secrets, and email keys. However, for a production environment, it is ideal to use environment variables to ensure the security of passwords and keys.</p>

<pre><code>
{
  "ConnectionStrings": {
    "DefaultConnection": "Host={IP of the database server};Port=5432;Database={name of database};Username={username};Password={password}"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  
  "JwtConfig": {
    "Secret": "{Your JWT secret}"
  },

  "EmailSettings": {
    "Host": "{your smtp provider like smtp.gmail.com}",
    "Port": {port},
    "Username": "{your email}",
    "Password": "{password}",

    "UseSsl": true
  },
  "AllowedHosts": "*"
}
</code></pre>

<h1>Deploy</h1>

<p>Choose the deployment strategy that best fits your needs. You can deploy your ASP.NET Web API application to a cloud provider of your choice, or set up your own server running Linux or Windows. For detailed instructions, refer to the official Microsoft documentation for deploying an ASP.NET Web API with .NET 8.</p>

<p>Here are some general steps and resources to guide you through the deployment process:</p>

<ul>
  <li><strong>Cloud Providers</strong>: You can choose from a variety of cloud providers such as Microsoft Azure, Amazon Web Services (AWS), Google Cloud Platform (GCP), etc. These providers offer managed services that can simplify the deployment and scaling of your application.</li>
  <li><strong>Self-hosted Server</strong>: You can set up your own server running Linux or Windows. This gives you more control over the environment but requires more setup and maintenance.</li>
</ul>

<h3>Deploying to Cloud Providers</h3>
<p>Follow the specific guidelines provided by your chosen cloud provider. Here are links to the documentation for some popular cloud providers:</p>
<ul>
  <li><a href="https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore">Azure App Service</a></li>
  <li><a href="https://aws.amazon.com/getting-started/hands-on/deploy-net-app-amazon-ecs/">AWS Elastic Container Service</a></li>
  <li><a href="https://cloud.google.com/dotnet/docs/setup">Google Cloud Platform</a></li>
</ul>

<h3>Self-hosted Deployment</h3>
<p>For self-hosted deployments, you can follow the official Microsoft documentation to set up your environment:</p>
<ul>
  <li><a href="https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx">Deploying to a Linux server with Nginx</a></li>
  <li><a href="https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-iis">Deploying to a Windows server with IIS</a></li>
</ul>

<h3>Database Server Setup</h3>
<p>Regardless of where you host your application, you'll need to set up a database server. Follow the documentation for your chosen database to set it up and configure it to work with your application:</p>


<p>Ensure that you follow best practices for securing your database, managing user permissions, and configuring backups.</p>

