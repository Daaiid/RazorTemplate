using System.ComponentModel.DataAnnotations;

namespace RazorTemplate.Db.Entities;

public class Event
{
    public int Id { get; set; }
    [MaxLength(255)]
    public required string Name { get; set; } 
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }

    public List<Attendee> Attendees { get; set; } = [];
}
