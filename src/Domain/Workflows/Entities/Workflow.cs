using Domain.Common.Entities;

namespace Domain.Workflows.Entities;

public class Workflow : Entity
{
    public required string Name { get; set; }
    public required string FriendlyId { get; set; }
    public List<Step>? Steps { get; set; }
}