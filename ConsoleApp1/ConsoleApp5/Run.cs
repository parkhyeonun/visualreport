using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Run
    {
        public const int MaxBoard= 3;
        int istrike, iboll , round;
        bool bswtich = true;

        List<String> listBoard = new List<String>();
        List<String> listRead = new List<String>();

        public void Strat()
        {
            Shuffle();

            while (bswtich)
            {
                PrintStart(5, ++round); 
                ReadBoard();
                socre();
                Result();
                Initialize();
            }
        }

        void Shuffle()
        {
            Random ran = new Random();
            int iran = 0;
            for (int i = 0; i < MaxBoard; )
            {
                iran = ran.Next(1, 10);
                if (listBoard.Contains(Convert.ToString(iran)))
                {
                    iran = ran.Next(1, 10);
                }
                else
                {
                    listBoard.Add(Convert.ToString(iran));
                    i++;
                }
                
            }

        }

        void ReadBoard()
        {
            String sboard = "";
            System.Console.Write("확인하고 싶은 숫자 3개를 써주세요(띄어쓰기 없음, 안적기 없음)"); sboard = System.Console.ReadLine();
            for (int i = 0; i < MaxBoard; i++)
            {
                listRead.Add(sboard.Substring(i,1));
            }




        }

        void socre()
        {
            
            for (int i = 0; i < listBoard.Count ; i++)
            {
             
                if(listBoard[i] == listRead[i])
                {
                    istrike++;
                }
                else
                {
                    iboll++;
                }
                
            }

        }

        void Result()
        {
            if(istrike == 3)
            {
                PrintResult(5,0,0,0);
                bswtich = false;
            }
            else if(round % 3 == 0)
            {
                PrintResult(4,0,0,0);
            }
            else
            {
                PrintResult(3,istrike,iboll ,0);
            }
        }

        void PrintStart(int inum, int inum2)
        {
            switch (inum)
            {
                case 5:
                    System.Console.WriteLine("라운드 : {0}", inum2);
                    break;
                default:
                    break;
            }

        }

        void PrintResult(int inum, int istrike ,int iboll , int round)
        {
            switch (inum)
            {

                case 3:
                    System.Console.WriteLine("result : S = {0}개 , B = {1} \n" , istrike ,iboll);
                    break;
                case 4:
                    System.Console.WriteLine("result : 아웃입니다.\n");
                    break;
                case 5:
                    System.Console.WriteLine("result : 정답입니다.\n");
                    break;
                case 6:
                    System.Console.WriteLine("고생하셨습니다! 총 플레이 {0}라운드 하셨습니다\n", round);
                    break;
                default:
                    break;
            }
            
        }

        void Initialize()
        {
            istrike = 0;
            iboll = 0;
            listRead.Clear();
        }




    }
}
