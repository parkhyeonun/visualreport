using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SideDish : Kfood
    {
        public override int Eat()
        {
            return GetCalorie();
        }
        public override int Starv()
        {
            return GetHunger();
        }

    }

}
