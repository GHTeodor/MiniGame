using MiniGame.App.Warriors;

namespace MiniGame.App
{
    public static class Menu
    {
        public static void ChoseUpdate(Warrior warrior, int powerPoints, int heroNum)
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine($"What do you want to increase Hero №{heroNum} by [{powerPoints}] points");
            Console.WriteLine("1 - +HP \n" +
                              "2 - +Armor \n" +
                              "3 - +Strength");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    warrior.AddSuperPower(new AddHP(), powerPoints);
                    break;
                case ConsoleKey.D2:
                    warrior.AddSuperPower(new AddArmor(), powerPoints);
                    break;
                case ConsoleKey.D3:
                    warrior.AddSuperPower(new AddStrength(), powerPoints);
                    break;
                default: ChoseUpdate(warrior, powerPoints, heroNum);
                    break;
            }
        }

        public static Warrior ChoseHero(int hero)
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine($"Choose hero №{hero} \n" +
                              $"1 - {new Archer()} \n" +
                              $"2 - {new Knight()} \n" +
                              $"3 - {new Ninja()} \n" +
                              $"4 - {new Witcher()}");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    return new Archer();
                case ConsoleKey.D2:
                    return new Knight();
                case ConsoleKey.D3:
                    return new Ninja();
                case ConsoleKey.D4:
                    return new Archer();
                // default: throw new ArgumentOutOfRangeException();
                default: return ChoseHero(hero);
            }
        }
    }
}