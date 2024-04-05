using Microsoft.AspNetCore.Authorization;

namespace NeurometaOncoAPI.Utils;

public class DynamicRoleAuthorizeAttribute : AuthorizeAttribute
{
    public DynamicRoleAuthorizeAttribute(Func<string> getRole)
    {
        Roles = getRole.Invoke();
    }
}