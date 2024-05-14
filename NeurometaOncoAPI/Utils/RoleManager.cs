using Microsoft.AspNetCore.Identity;
using NeurometaOncoAPI.Domain.DomainModels.Models.Auth;

namespace NeurometaOncoAPI.Utils
{
    public class RoleManager
    {

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            string[] rolesNames = { "Admin", "Paciente", "Psicologo" };
            IdentityResult result;
            foreach (var namesRole in rolesNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(namesRole);
                if (!roleExist)
                {
                    result = await roleManager.CreateAsync(new IdentityRole(namesRole));
                }
            }
        }
    }
}
