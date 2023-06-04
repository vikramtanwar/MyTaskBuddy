using Microsoft.AspNetCore.Mvc;

namespace MyTaskBuddy.Controllers;

public class Calender : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}