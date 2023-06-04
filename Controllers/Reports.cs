using Microsoft.AspNetCore.Mvc;

namespace MyTaskBuddy.Controllers;

public class Reports : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}