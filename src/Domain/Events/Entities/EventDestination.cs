namespace Domain.Events.Entities;

public class EventDestination
{
    public long Id { get; set; }
    public string? SubscriberId { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Group { get; set; }
}