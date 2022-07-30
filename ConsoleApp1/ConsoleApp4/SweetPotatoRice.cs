using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SweetPotatoRice : Kfood
    {

        public override int Eat()
        {
            System.Console.WriteLine("고구마밥을 먹었다(탄수화물이 많이 늘었다)");
            return GetCarbohydrate();
        }

        public override int Starv()
        {
            System.Console.WriteLine("고구마밥을 안먹었다(조금 배고프다)");
            return GetHunger()/2;
        }

    }
}
