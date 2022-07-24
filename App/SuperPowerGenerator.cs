using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame.App
{
    public class SuperPowerGenerator
    {
        public static int GetRandom()
        {
            return new Random().Next(5, 11);
        }
    }
}
