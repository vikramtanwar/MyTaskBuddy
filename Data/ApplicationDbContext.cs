using Microsoft.EntityFrameworkCore;
using MyTaskBuddy.Models;

namespace MyTaskBuddy.Data;

public class ApplicationDbContext :DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}