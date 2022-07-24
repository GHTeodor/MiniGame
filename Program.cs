using MiniGame.App;
using MiniGame.App.Warriors;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
/*Console.WriteLine($"Random number: {SuperPowerGenerator.GetRandom()}");

Archer archer = new Archer();
Knight knight = new Knight();
Ninja ninja = new Ninja();
Witcher witcher = new Witcher();

Console.WriteLine(archer);
Console.WriteLine(knight);
Console.WriteLine(ninja);
Console.WriteLine(witcher);

archer.AddSuperPower(new AddStrength(), SuperPowerGenerator.GetRandom());
archer.AddSuperPower(new AddArmor(), SuperPowerGenerator.GetRandom());
archer.AddSuperPower(new AddHP(), SuperPowerGenerator.GetRandom());

archer.HP = 0;
Console.WriteLine(archer);*/

var warrior1 = Menu.Hero(1);
var warrior2 = Menu.Hero(2);

int addHero1 = SuperPowerGenerator.GetRandom();
Console.WriteLine("\n Що ви хочете покращити першому Герою №1 на [" + addHero1 + "] пунктів");
Menu.Update(warrior1, addHero1);

int addHero2 = SuperPowerGenerator.GetRandom();
Console.WriteLine("\n Що ви хочете покращити першому Герою №2 на [" + addHero2 + "] пунктів");
Menu.Update(warrior2, addHero2);

Console.WriteLine("Герой №1 " + warrior1);
Console.WriteLine("Герой №2 " + warrior2);

Scene.Fight(warrior1, warrior2);
