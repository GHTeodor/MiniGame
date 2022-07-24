using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App.Warriors
{
    public class Knight : Warrior
    {
        public Knight()
        {
            Armor = 10;
            Strength = 20 - Armor;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP:={HP} Armor:={Armor} Strength:={Strength}";
        }
    }
}
