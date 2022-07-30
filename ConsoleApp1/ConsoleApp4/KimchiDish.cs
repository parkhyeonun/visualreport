using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class KimchiDish : SideDish
    {
        public override int Eat()
        {
            System.Console.WriteLine("김치를 먹었다(칼로리가 변하지 않았다)");
            return 0;
        }
        public override int Starv()
        {
            System.Console.WriteLine("김치를 안먹었다(행복하다)");
            return GetHunger();
        }

    }
}
