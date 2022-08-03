using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Lotto
    {
        public const int LottoMaxNumber = 45;
        public const int ShuffleCount = 50;
        public const int gadcha = 5;

        List<String> LottoNumber = new List<string>();

        public void CreateLottoNumber()
        {
            for (int i = 1; i <= LottoMaxNumber; i++)
            {
                LottoNumber.Add(Convert.ToString(i));
            }
        }

        public void ShuffleLottoNumber()
        {
            Random ran = new Random();
            String stemp;
            int iran;
            
            for(int i = 0; i < ShuffleCount; i++)
            {
                iran = ran.Next(0, 45);
                stemp = LottoNumber[iran];
                LottoNumber[iran] = LottoNumber[i % LottoMaxNumber];
                LottoNumber[i % LottoMaxNumber] = stemp;

            }
        }

        public List<String> GetLottoNumber()
        {
            List<String> rslist = new List<string>();

            for (int i = 0; i < gadcha; i++)
            {
                rslist.Add(LottoNumber[i]);
            }

            return rslist;
        }

        public override String ToString()
        {
            String sadd = "";

            for (int i = 0; i < gadcha; i++)
            {
                sadd += " " + LottoNumber[i]; 
            }
            
            return sadd;
        }


    }
}
