using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Identity;

namespace eProject.Seeding;

public class DbInitializer
{
    private readonly DatabaseContext _context;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public DbInitializer(DatabaseContext context, RoleManager<IdentityRole> roleManager,
        UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task SeedAsync()
    {
        var adminRole = await _roleManager.FindByNameAsync("Administrator");
        if (adminRole == null)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = "Administrator" });
        }

        var admin = new ApplicationUser
        {
            Name = "Admin",
            Email = "admin@noemail.com",
            UserName = "admin@noemail.com"
        };
        await _userManager.CreateAsync(admin, "Admin@123");
        await _userManager.AddToRoleAsync(admin, "Administrator");
    }
}