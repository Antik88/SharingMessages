namespace SharingMessages;

public record RentRecord(Guid Id, ThingModel Thing, DateTime StartDate, DateTime EndDate);
