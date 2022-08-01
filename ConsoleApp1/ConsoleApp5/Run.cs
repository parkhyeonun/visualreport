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
            Shuffle();              //컴퓨터 랜덤 숫자 셔플

            while (bswtich)
            {
                PrintStart(++round); //시작문구 출력
                ReadBoard();         //3글자 입력
                socre();             //점수 계산
                PrintResult();       //결과 출력
                Initialize();        //초기화
            }
        }

        void Shuffle()
        {
            Random ran = new Random();
            int iran = 0;

            for (int i = 0; i < MaxBoard; )
            {
                iran = ran.Next(1, 10);
                if (listBoard.Contains(Convert.ToString(iran)))        //랜덤 숫자 중복 방지 List 방법 1
                {                                                      //미리리스트에 숫자 1~9 넣고 랜덤으로 스위칭하여도 됨 방법2
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

        void PrintResult()
        {
            if(istrike == 3) //정답입니다.
            {
                System.Console.WriteLine("result : 정답입니다.\n");
                bswtich = false;
                System.Console.WriteLine("고생하셨습니다! 총 플레이 {0}라운드 하셨습니다\n", round);
            }
            else if(iboll == 3) //아웃입니다.
            {
                System.Console.WriteLine("result : 아웃입니다.\n");
            }
            else //게임 계속진행
            {
                System.Console.WriteLine("result : S = {0}개 , B = {1} \n", istrike, iboll);
            }
        }

        void PrintStart(int inum)
        {
                    System.Console.WriteLine("라운드 : {0}", inum);
        }


        void Initialize()
        {
            istrike = 0;
            iboll = 0;
            listRead.Clear();
        }




    }
}
