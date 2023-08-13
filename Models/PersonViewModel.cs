using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models;

public class PersonViewModel
{
    [Required]
    [RegularExpression(@"^[a-zA-Z]+( [a-zA-Z]+)*$", ErrorMessage = "Use letters only and only one space between names, please")]
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age
    {
        // Turn this into a property
        get
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            // Check if the birthday has occurred this year
            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}