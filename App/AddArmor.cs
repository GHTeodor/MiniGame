using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public class AddArmor : ISuperPower
    {
        public virtual int AddSuperPower(Warrior warrior, int armor)
        {
            return warrior.Armor += armor;
        }
    }
}
