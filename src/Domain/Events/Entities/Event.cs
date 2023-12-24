namespace Domain.Events.Entities;

public class Event
{
    public long Id { get; set; } 
    public List<EventDestination>? Destinations { get; set; }
    public required int WorkflowId { get; set; }
    public Dictionary<string,string>? Data { get; set; }
}