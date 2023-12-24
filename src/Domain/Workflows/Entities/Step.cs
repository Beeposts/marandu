using Domain.Channels.Entities;
using Domain.Common.Entities;

namespace Domain.Workflows.Entities;

public class Step: Entity
{
    public required string Name { get; set; }
    public required string Configuration { get; set; }
    public required Channel Channel { get; set; }
    public required int ChannelId { get; set; }
    public required int Order { get; set; }
}