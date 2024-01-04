using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Admin.Controllers;

public class UserController : Controller
{
    private readonly DatabaseContext _context;
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly IConfiguration configuration;

    public UserController(DatabaseContext context, SignInManager<ApplicationUser> signInManager,
        IConfiguration configuration)
    {
        _context = context;
        this.signInManager = signInManager;
        this.configuration = configuration;
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        HttpContext.Request.Cookies.TryGetValue("token", out var token);
        if (!token.IsNullOrEmpty())
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(SignInModel model)
    {
        var result = await SignInAsync(model);
        if (result.IsNullOrEmpty())
        {
            return Unauthorized();
        }

        HttpContext.Response.Cookies.Append("token", result);
        return RedirectToAction("Index", "Home");
    }

    private async Task<string> SignInAsync(SignInModel model)
    {
        var role = (from r in _context.Roles
            join ur in _context.UserRoles on r.Id equals ur.RoleId
            join u in _context.Users on ur.UserId equals u.Id
            where u.Email == model.Email
            select r.Name).FirstOrDefault();

        if (role != "Administrator")
        {
            return string.Empty;
        }

        var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        if (!result.Succeeded)
        {
            return string.Empty;
        }

        var authClaims = new List<Claim>
        {
            new(ClaimTypes.Email, model.Email),
            new(ClaimTypes.Role, role),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
        var authenKey =
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration["JWT:Secret"] ?? throw new InvalidOperationException()));
        var token = new JwtSecurityToken(
            issuer: configuration["JWT:ValidIssuer"],
            audience: configuration["JWT:ValidAudience"],
            expires: DateTime.Now.AddHours(1),
            claims: authClaims,
            signingCredentials: new SigningCredentials(
                authenKey, SecurityAlgorithms.HmacSha512Signature
            )
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}