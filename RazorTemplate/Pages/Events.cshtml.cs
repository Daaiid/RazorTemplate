using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTemplate.Db;
using RazorTemplate.Db.Entities;

namespace RazorTemplate.Pages;

public class Events : PageModel
{
    private readonly DataContext _context;

    public Events(DataContext context)
    {
        _context = context;
    }
    
    public List<Event> AllEvents { get; set; } = [];


    public void OnGet()
    {
        AllEvents = _context.Events.Include(p => p.Attendees).ToList();
    }
}