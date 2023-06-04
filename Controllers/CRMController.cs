using Microsoft.AspNetCore.Mvc;

namespace MyTaskBuddy.Controllers;

public class CRMController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}