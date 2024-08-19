using System.ComponentModel.DataAnnotations;

namespace RazorTemplate.Db.Entities;


public class Attendee
{
    public int Id { get; set; }
    [MaxLength(255)]
    public required string Name { get; set; }
    public DateOnly? Birthday { get; set; }

    public List<Event> Events { get; set; } = [];
}