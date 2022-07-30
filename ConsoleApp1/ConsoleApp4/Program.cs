using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Happiness = 0;
            int calorie = 0;
            int carbohydrate = 0;
            int hunger = 0;
            String name = "사람";

            
            KimchiDish kimc = new KimchiDish();
            MeatDish meat = new MeatDish();
            PotatoRice potat = new PotatoRice();
            SweetPotatoRice spotat = new SweetPotatoRice();
            kimc.init();
            meat.init();
            potat.init();
            spotat.init();

            System.Console.WriteLine();
            carbohydrate += potat.Eat();
            carbohydrate += spotat.Eat();
            System.Console.WriteLine();
            Happiness += kimc.Starv();
            Happiness += meat.Starv();
            System.Console.WriteLine();
            calorie += kimc.Eat();
            calorie += meat.Eat();
            System.Console.WriteLine();
            hunger += potat.Starv();
            hunger += spotat.Starv();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine(name);
            System.Console.WriteLine("행복도 : {0} 칼로리 : {1} 탄수화물 : {2} 공복 : {3}", Happiness , calorie , carbohydrate , hunger);



        }
    }
}
