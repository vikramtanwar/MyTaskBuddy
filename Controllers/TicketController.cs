using Microsoft.AspNetCore.Mvc;
using MyTaskBuddy.Models;
using MyTaskBuddy.Data;

namespace MyTaskBuddy.Controllers;

public class TicketController : Controller
{
    private ApplicationDbContext _db;
    public TicketController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Ticket> taskList = _db.Tickets.ToList();
        return View(taskList);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Ticket task)
    {
        if (ModelState.IsValid)
        {
            _db.Tickets.Add(task);
            _db.SaveChanges();
        }
        return View("Index");
    }
    
}