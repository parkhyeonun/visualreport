using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Kfood : FoodInterface
    {
        private int happiness = 0;
        private int calorie = 0;
        private int carbohydrate = 0;
        private int hunger = 0;

        public void init()
        {
            happiness = 25;
            calorie = 15;
            carbohydrate = 20;
            hunger = 10;
       }

        public virtual int Eat()
        {
            return 0;
        }
         public virtual int Starv()
        {
            return 0;
        }

        public void SetHappiness(int happiness)
        {
            this.happiness = happiness;
        }
        public int GetHappiness()
        {
            return this.happiness;
        }
        public void SetCalorie(int calorie)
        {
            this.calorie = calorie;
        }

        public int GetCalorie()
        {
            return this.calorie;
        }
        public void SetCarbohydrate(int carbohydrate)
        {
            this.carbohydrate = carbohydrate;
        }
        public int GetCarbohydrate()
        {
            return this.carbohydrate;
        }
        public void SetHunger(int hunger)
        {
            this.hunger = hunger;
        }
        public int GetHunger()
        {
            return this.hunger;
        }

    }
}
