using MiniGame.App;
using MiniGame.App.Warriors;

Console.WriteLine($"Random number: {SuperPowerGenerator.GetRandom()}");

Archer archer = new Archer();
Knight knight = new Knight();
Ninja ninja = new Ninja();
Witcher witcher = new Witcher();

Console.WriteLine(archer);
Console.WriteLine(knight);
Console.WriteLine(ninja);
Console.WriteLine(witcher);