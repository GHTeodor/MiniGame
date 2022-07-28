using MiniGame.App;
using System.Text;
using MiniGame.App.HW2;

Console.OutputEncoding = Encoding.Unicode;

do
{
    List<Warrior> warriors = new List<Warrior>();

    int iter = 1;
    int players = NumberOfPlayers.Players();

    while (warriors.Count() < players)
    {
        warriors.Add(Menu.Hero(warriors.Count() + 1));
        
        int addToHero = SuperPowerGenerator.GetRandom();
        Console.WriteLine($"\n Що ви хочете покращити Герою №{iter--} на [{addToHero}] пунктів");
        Menu.Update(warriors.Skip(iter++).First(), addToHero);
        iter++;
    }

    iter = 0;
    int fightNum = 1;
    
    while (warriors.Count() > 0)
    {
        Console.WriteLine($"\n New Fight {fightNum++} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        var warrior1 = warriors.Skip(iter++).First();
        var warrior2 = warriors.Skip(iter++).First();
        Scene.Fight(warrior1, warrior2);
        warriors.RemoveRange(0, 2);
        iter = 0;
    }
    
} while (NewGameAgain.RepeatGame());

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