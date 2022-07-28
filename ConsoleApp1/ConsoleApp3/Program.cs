using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 , 4 , 5 , 6 , 7 , 8, 9 ,10
            //0 , 1 , 2 , 3 , 4 , 5, 6 , 7
            int irow;
           
            System.Console.Write("Input : "); irow = int.Parse(System.Console.ReadLine());
            int iadd = irow - 3;

            System.Console.WriteLine();

            for (int i = 0; i < irow; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            for (int i = 0; i < irow; i++)
            {
                for (int j = irow - i; j > 0; j--)
                {
                    System.Console.Write(' ');
                }

                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            for (int i = 0; i < irow; i++)
            {
                for (int j = irow - i; j > 0; j--)
                {
                    System.Console.Write(' ');
                }

                for (int j = 0; j < 1 + ( 2 * i ) ; j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            for (int i = 0; i < irow; i++)
            {
                for (int j = irow - i; j > 0; j--)
                {
                    System.Console.Write(' ');
                }

                for (int j = 0; j < 1 + (2 * i); j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < irow; i++)
            {
                for (int j = 0; j < i + 2; j++)
                {
                    System.Console.Write(' ');
                }

                for (int j = 0;  j < (irow + iadd) - ( 2 * i ); j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            System.Console.WriteLine();



        }
    }
}
