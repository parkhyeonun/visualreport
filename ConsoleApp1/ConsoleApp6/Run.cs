using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Run
    {
        List<String> ListRead = new List<string>();
        List<String> ListRan = new List<string>();
        Lotto lotto = new Lotto();
        int iscore = 0;

        public void Start()
        {
            for (int i = 1; i < 6; i++)
            {
                System.Console.Write("{0}번째 숫자를 입력하세요 (1~45) : " , i );ListRead.Add(System.Console.ReadLine());
            }

            lotto.CreateLottoNumber();
            lotto.ShuffleLottoNumber();
            ListRan = lotto.GetLottoNumber();

            for (int i = 0; i < 5; i++)
            {
                if (ListRan.Contains(ListRead[i]) )
                {
                    iscore++;
                }    
            }

            System.Console.WriteLine();

            switch (iscore)
            {
                case 1:
                    System.Console.WriteLine("5등 당첨!");
                    break;
                
                case 2:
                    System.Console.WriteLine("4등 당첨!");
                    break;
                
                case 3:
                    System.Console.WriteLine("3등 당첨!");
                    break;
                
                case 4:
                    System.Console.WriteLine("2등 당첨!");
                    break;
                
                case 5:
                    System.Console.WriteLine("1등 당첨!");
                    break;
                case 0:
                    System.Console.WriteLine("꽝!");
                    break;

            }

            System.Console.WriteLine();
            System.Console.WriteLine(" 번호는 : " + lotto.ToString() + "입니다") ;
            System.Console.WriteLine();

        }

    }
}
