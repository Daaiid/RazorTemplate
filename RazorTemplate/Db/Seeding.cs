using Microsoft.EntityFrameworkCore;
using RazorTemplate.Db.Entities;

namespace RazorTemplate.Db;

public static class Seeding
{
    public static void Seed(DataContext context)
    {
        context.Database.EnsureCreated();

        var attendees = context.Attendees.Count();
        if (attendees > 0)
        {
            return;
        }

        // Seeding the database with example data
        var dave = new Attendee { Id = 1, Name = "Dave", Birthday = new DateOnly(1969, 4, 20) };
        var oli = new Attendee { Id = 2, Name = "Oli" };
        var anna = new Attendee { Id = 3, Name = "Anna" };

        var @event = new Event
        {
            Id = 1,
            Name = "Project of Commerce",
            Start = new DateTimeOffset(new DateTime(2024, 9, 16), TimeSpan.FromHours(2)).ToUniversalTime(),
            End = null,
            Attendees = [oli, anna],
        };

        context.Events.Add(@event);
        context.Attendees.Add(dave);
        context.SaveChanges();
    }
}