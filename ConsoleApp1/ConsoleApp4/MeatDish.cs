using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MeatDish : SideDish
    {
        public override int Eat()
        {
            System.Console.WriteLine("고기를 먹었다(칼로리가 조금 늘었다)");
            return GetCalorie() / 2;
        }
        public override int Starv()
        {
            System.Console.WriteLine("고기를 안먹었다(행복하지 않다)");
            return 0;
        }

    }
}
