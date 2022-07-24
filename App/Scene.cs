using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public static class Scene
    {
        public static void Fight(Warrior warrior1, Warrior warrior2)
        {
            int round = 1;
            while(warrior1.isAlive && warrior2.isAlive) {
                Defense(Attack(warrior1), warrior2);
                Defense(Attack(warrior2), warrior1);
                round++;
                Console.WriteLine(round + " round:\n" + warrior1 + "\n" + warrior2 + "\n");
            }
            if (!warrior1.isAlive && !warrior2.isAlive) Console.WriteLine("Draft in " + round + "round");
            else if (!warrior1.isAlive && warrior2.isAlive)
                    Console.WriteLine(warrior2 + " Winner in " + round + "round");

            else if(!warrior2.isAlive && warrior1.isAlive)
                    Console.WriteLine(warrior1 + " Winner in " + round + "round");
            
        }

        public static int Attack(Warrior warrior)
        {
            if (warrior.Armor > 0) return warrior.Strength;
            else
                return warrior.Strength > 0 ? warrior.Strength-- : 1;
        }

        public static void Defense(int attack, Warrior warrior)
        {
            if (warrior.Armor > 0 && warrior.Armor - attack >= 0) {
                attack /= 2;
                warrior.Armor -= attack;
                warrior.HP -= attack;
            }
            else if (warrior.Armor > 0 && warrior.Armor - attack < 0)
            {
                attack -= warrior.Armor;
                warrior.Armor = 0;
                warrior.HP -= attack;
            }
            else warrior.HP -= attack;
        }
    }
}
