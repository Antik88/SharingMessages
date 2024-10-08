﻿namespace SharingMessages;

public record RentRecord(Guid Id,
    ThingModel Thing,
    UserModel Owner, 
    UserModel Tenant,
    DateTime StartDate,
    DateTime EndDate,
    string Status,
    MessageType MessageType = MessageType.NewRent);
