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
            Defense(Attack(warrior1), warrior2);
            Defense(Attack(warrior2), warrior1);
        }

        public static int Attack(Warrior warrior)
        {
            if (warrior.Armor > 0) return warrior.Strength;
            else
                return warrior.Strength > 0 ? warrior.Strength-- : 1;
        }

        public static void Defense(int attack, Warrior warrior)
        {
            if (warrior.Armor > 0 && warrior.Armor - attack > 0) {
                attack /= 2;
                warrior.Armor -= attack;
                warrior.HP -= attack;
            }
            else if (warrior.Armor > 0)
            {
                attack -= warrior.Armor;
                warrior.Armor = 0;
                warrior.HP -= attack;
            }
            else warrior.HP -= attack;
        }
    }
}
