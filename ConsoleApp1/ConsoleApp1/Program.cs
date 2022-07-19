using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1, s2;

            System.Console.Write("Input s1 : "); s1 = System.Console.ReadLine();
            System.Console.Write("Input s2 : "); s2 = System.Console.ReadLine();

            System.Console.WriteLine("The String is \n" +
                                         s1 + ", " + s2);
            System.Console.WriteLine("The String is \n" +
                                     $"{s1}, {s2} ");
            System.Console.WriteLine(@"The String is
{0}, " + "{1}", s1, s2);

            var tmp = (strs0: "The String is \n", strs1: s1, strs2: ", " + s2);
            //(String strs0, String strs1, String strs2) tmp = ("The String is \n", s1, ", " + s2);  
            //System.Console.WriteLine("{0}{1}{2}" , tmp.strs0 , tmp.strs1 , tmp.strs2);
            System.Console.WriteLine(tmp.strs0 + tmp.strs1 + tmp.strs2);



            String[] strarr = { "The String is", s1 + ", " + s2 };
            foreach (var value in strarr)
                System.Console.WriteLine(value);
        }
    }
}
