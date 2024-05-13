using Microsoft.AspNetCore.Identity;

namespace HumanResourcesApp
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
