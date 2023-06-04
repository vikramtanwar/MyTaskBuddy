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
            return RedirectToAction("Index");
        }
        return View();
    }
    
    public IActionResult Edit(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }

        Ticket taskFromDb = _db.Tickets.Find(id);
        if(taskFromDb == null)
        {
            return NotFound();
        }
        return View(taskFromDb);
    }
    
    [HttpPost]
    public IActionResult Edit(Ticket task)
    {
        if (ModelState.IsValid)
        {
            _db.Tickets.Update(task);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
    

    public IActionResult Delete(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }

        Ticket taskFromDb = _db.Tickets.Find(id);
        if(taskFromDb == null)
        {
            return NotFound();
        }
        _db.Tickets.Remove(taskFromDb);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

}