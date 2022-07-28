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
            int irow = 5;

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

            for (int i = 0; i < irow - 1; i++)
            {
                for (int j = 0; j < i + 2; j++)
                {
                    System.Console.Write(' ');
                }

                for (int j = 0;  j < (irow + 2) - (2 * i); j++)
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
