using QuantInfrastructure.Core;

var rand = new Random();

while (true)
{
    var tick = new MarketTick(
        Symbol: "EURUSD",
        Price: Math.Round((decimal)(1.05 + rand.NextDouble() * 0.01), 5),
        Timestamp: DateTime.UtcNow
    );

    Console.WriteLine($"Produced Tick: {tick.Symbol} {tick.Price} {tick.Timestamp}");

    await Task.Delay(500);
}