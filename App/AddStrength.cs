using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public class AddStrength : ISuperPower
    {
        public virtual int AddSuperPower(Warrior warrior, int strength)
        {
            return warrior.Strength += strength;
        }
    }
}
