using QuantInfrastructure.Core;

var rand = new Random();

while (true)
{
    var tick = new MarketTick(
        "EURUSD",
        Math.Round((decimal)(1.05 + rand.NextDouble() * 0.01), 5),
        DateTime.UtcNow
    );

    var spread = Math.Round(tick.Price * 0.0002m, 6);

    Console.WriteLine($"Processed Tick: {tick.Symbol} {tick.Price} Spread:{spread}");

    await Task.Delay(500);
}