using Microsoft.EntityFrameworkCore;
using RazorTemplate.Db.Entities;

namespace RazorTemplate.Db;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Event> Events { get; set; }
    public DbSet<Attendee> Attendees { get; set; }

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("RazorTemplate"));
    }

}