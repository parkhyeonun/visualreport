using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PotatoRice : Rice
    {

        public override int Eat()
        {
            System.Console.WriteLine("감자밥을 먹었다(탄수화물이 조금 늘었다)");
            return GetCarbohydrate() / 2;
        }

        public override int Starv()
        {
            System.Console.WriteLine("감자밥을 안먹었다(배고프다)");
            return GetHunger();
        }

    }
}
