namespace SharingMessages;

public class ThingModel
{
    public Guid ThingId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required double Price { get; set; }
    public Guid OwnerId { get; set; }
}
