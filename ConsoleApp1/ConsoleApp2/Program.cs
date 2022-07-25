using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float fresult = 0;
            float f1 = 0; 
            float f2 = 0; 
            char  c1 ;

            System.Console.Write("Input : "); f1 = float.Parse(System.Console.ReadLine());
            System.Console.Write("type  : "); c1 = char.Parse(System.Console.ReadLine());
            System.Console.Write("Input : "); f2 = float.Parse(System.Console.ReadLine());


            cal(f1 , f2 , c1);




            void cal(float ff1, float ff2, char cc1)
            {
                switch(cc1)
                {
                    case '+':
                        fresult = ff1 + ff2;
                        break;
                    case '-':
                        fresult = ff1 - ff2;
                        break;
                    case '*':
                        fresult = ff1 * ff2;
                        break;
                    case '/':
                        fresult = ff1 / ff2;
                        break;
                    
                }
                System.Console.WriteLine("result : {0}" , fresult);
                run(fresult);

            }

            void run(float fff1)
            {
                char ccc1;
                float fff2;
                System.Console.Write("continue?(y/n) : ");ccc1 = char.Parse(System.Console.ReadLine());
                switch (ccc1)
                {
                    case 'y':
                        System.Console.Write("type : ");ccc1 = char.Parse( System.Console.ReadLine());
                        System.Console.Write("input : ");fff2 = float.Parse(System.Console.ReadLine());
                        cal(fff1 , fff2 , ccc1);
                        break;
                  
                    case 'n':
                        System.Console.WriteLine("Finish");
                        return;


                }
            }
        }
    }
}
