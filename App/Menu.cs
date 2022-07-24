using MiniGame.App.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public static class Menu
    {
        public static void Update(Warrior warrior, int addPower)
        {
            Console.WriteLine("1 - +HP \n" +
                "2 - +Armor \n" +
                "3 - +Strength \n");
            switch (Console.ReadLine())
            {
                case "1":
                    warrior.AddSuperPower(new AddHP(), addPower);
                    break;
                case "2":
                    warrior.AddSuperPower(new AddArmor(), addPower);
                    break;
                case "3":
                    warrior.AddSuperPower(new AddStrength(), addPower);
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static Warrior Hero(int hero)
        {
            Console.WriteLine($"Оберіть героя №{hero++} \n" +
            $"1 - {new Archer()} \n" +
            $"2 - {new Knight()} \n" +
            $"3 - {new Ninja()} \n" +
            $"4 - {new Witcher()} \n");

            switch (Console.ReadLine())
            {
                case "1":
                    return new Archer();
                case "2":
                    return new Knight();
                case "3":
                    return new Ninja();
                case "4":
                    return new Archer();
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
