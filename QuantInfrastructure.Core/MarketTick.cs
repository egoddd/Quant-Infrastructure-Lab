namespace QuantInfrastructure.Core;

public sealed record MarketTick(
    string Symbol,
    decimal Price,
    DateTime Timestamp
);