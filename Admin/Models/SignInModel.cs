using System.ComponentModel.DataAnnotations;

namespace Admin.Models;

public class SignInModel
{
    [EmailAddress] public string Email { get; set; } = null!; 
    public string Password { get; set; } = null!;
}