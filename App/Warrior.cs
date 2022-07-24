using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public abstract class Warrior
    {
        public int HP { get; set; } = 100;
        public int Armor { get; set; }
        public int Strength { get; set; }
        public bool isAlive { get => HP > 0; }

        public virtual void AddSuperPower(ISuperPower superPower, int quantity)
        {
            superPower.AddSuperPower(this, quantity);
        }
    }
}
