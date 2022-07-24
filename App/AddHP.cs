using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public class AddHP : ISuperPower
    {
        public virtual int AddSuperPower(Warrior warrior, int hp)
        {
            return warrior.HP += hp;
        }
    }
}
