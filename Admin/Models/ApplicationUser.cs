using Microsoft.AspNetCore.Identity;

namespace Admin.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
