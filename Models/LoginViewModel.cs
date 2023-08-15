using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models;

public class LoginViewModel
{
    [Required]
    [Display(Name = "Username")]
    public string? Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string? Password { get; set; }
    public string? ReturnUrl { get; set; }
}

