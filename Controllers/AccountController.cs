using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers;

public class AccountController : Controller
{
    // Mocked user data
    private const string MockedUsername = "demo";
    private const string MockedPassword = "pass"; // Note: NEVER hard-code passwords in real applications.

    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // This ensures that the form is submitted with a valid anti-forgery token to prevent CSRF attacks.
    public ActionResult Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        // Mocked user verification
        if (model.Username == MockedUsername && model.Password == MockedPassword)
        {
            // Normally, here you'd set up the session/cookie for the authenticated user.
            return RedirectToAction("Index", "Home"); // Redirect to a secure area of your application.
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt."); // Generic error message for security reasons.
        return View(model);
    }
}