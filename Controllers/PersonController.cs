using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MVCDemo.Models;
using MVCDemo.ApplicationServices;

namespace MVCDemo.Controllers;

public class PersonController : Controller
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    public IActionResult PersonInfo()
    {
        // Get the person from the service
        var personDTO = _personService.GetPerson();
        var person = new PersonViewModel
        {
            Name = personDTO.Name,
            BirthDate = personDTO.BirthDate
        };

        var persons = new List<PersonViewModel>
        {
            person
        };
        
        return View(persons);
    }
}

