using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MVCDemo.Models;
using MVCDemo.ApplicationServices;

namespace MVCDemo.Controllers;

public class DemoController : Controller
{
    private readonly IPersonService _personService;

    public DemoController(IPersonService personService)
    {
        _personService = personService;
    }

    public string Index()
    {
        return "This is my action...";
    }

    public string HelloWorld()
    {
        return HtmlEncoder.Default.Encode("Hello World!");
    }
    
    public string Hello(string name, string ID = "1")
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, {ID}!");
    }

    public IActionResult Goodbye (string name)
    {
        var message = $"Goodbye {name}!";
        return Content(message, "text/html");
    }
    [HttpGet]
    public IActionResult DemoAction ()
    {
        ViewData["Message"] = "This is a demo action.";
        return View();
    }

    [HttpPost]
    public IActionResult DemoAction(string name)
    {
        ViewData["Name"] = $"Hello {name}!";
        return View();
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

        // Comment out the old code
        // var person = new Person
        // {
        //     Name = "John",
        //     Age = 42
        // };

        return View(person);
    }

    [HttpPost]
    public IActionResult PersonInfo(Person model)
    {
        if (ModelState.IsValid)
        {
            // Save to database or any other logic here
            //return RedirectToAction("Success"); // Redirect to a success page
            return View(model);
        }

        // If the model is not valid, return the same view to display errors
        return View(model);
    }
}

