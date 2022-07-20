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

            var s1 = System.Console.ReadLine();
            (int idata ,  float fdata, String sdata)result;


            result.idata = Convert.ToInt32(s1);
            result.fdata = result.idata * 1.0F;
            result.sdata = Convert.ToString(result.fdata);

            result.idata = int.Parse(s1);
            result.fdata = result.idata;
            result.sdata = String.Format("{0:F2}" , result.fdata);

            int idata = default(int);
            float fdata = default(float);
            string sdata ;

            int.TryParse(s1, out idata);
            fdata = (float)result.idata;
            sdata = new StringBuilder().Append(fdata).ToString();

            /*
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
            */
        }
    }
}
