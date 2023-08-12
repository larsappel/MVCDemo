using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models;

public class Person
{
    [Required]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only, please")]
    public string? Name { get; set; }
    public int Age { get; set; }
}