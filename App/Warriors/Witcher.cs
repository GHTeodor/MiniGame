using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App.Warriors
{
    public class Witcher : Warrior
    {
        public Witcher()
        {
            Armor = 7;
            Strength = 20 - Armor;
        }
    public override string ToString()
    {
        return $"{this.GetType().Name}: HP:={HP} Armor:={Armor} Strength:={Strength}";
    }
}
}
