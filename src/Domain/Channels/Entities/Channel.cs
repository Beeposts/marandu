namespace Domain.Channels.Entities;

public class Channel
{
    public required string Name { get; set; }
    public required string Configuration { get; set; }
    public required ChannelType Type { get; set; }
    public required ChannelVendor Vendor { get; set; }
}