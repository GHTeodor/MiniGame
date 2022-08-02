using MiniGame.App;
using System.Text;
using MiniGame.App.HW2;

Console.OutputEncoding = Encoding.Unicode;

do
{
    List<Warrior> warriors = new List<Warrior>();
    
    int playersNum = PlayerHelper.GetNumberOfPlayers();

    while (warriors.Count() < playersNum)
    {
        var hero = Menu.ChoseHero(warriors.Count() + 1);
        warriors.Add(hero);
        
        int addSPower = new SuperPowerGenerator().GetRandom();

        Menu.ChoseUpdate(hero, addSPower, warriors.Count());
    }
    
    var duels = warriors.Chunk(2);
    for (int i = 0; i < duels.Count(); i++)
    {
        Console.WriteLine($"\n\nNew Fight {i + 1} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        
        var warrior1 = duels.ElementAt(i).First();
        var warrior2 = duels.ElementAt(i).Last();
        Scene.Fight(warrior1, warrior2);
    }
} while (StartGameHelper.RepeatGame());

// // Operators in class
// OperatorsInClass op = new OperatorsInClass();
// OperatorsInClass op1 = new OperatorsInClass();
// OperatorsInClass op2 = new OperatorsInClass();
// Console.WriteLine(op1.ToString());
// Console.WriteLine(op2.ToString());
// op = op1 + op2;
// Console.WriteLine("+" + op.ToString());
// op = op1 - op2;
// Console.WriteLine("-" + op.ToString());
// op = op1 * op2;
// Console.WriteLine("*" + op.ToString());
// op = op1 / op2;
// Console.WriteLine("/" + op.ToString());