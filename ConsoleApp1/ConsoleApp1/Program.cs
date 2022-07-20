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
            //참고 사이트 https://docs.microsoft.com/ko-kr/dotnet/api/system.int32.parse?view=net-6.0
            //입력 받을 변수 선언 및 초기화
            var s1 = System.Console.ReadLine();
            
            //튜플형식 변수 선언 - Enum Class (인터넷 참고)
            (int idata ,  float fdata, String sdata)result;

            //Convert 클래스
            //바이너리티 코드 값을 다른 자료형으로 반환하는 클래스 (기능이 많음 - 오버로딩 (인터넷 참고) )
            result.idata = Convert.ToInt32(s1);                     //ToInt32(String) 문자열을 (Int32 = Int) 변경
            result.fdata = result.idata * 1.0F;                     //(int) * (float)  = (float)묵시적 형변환 (인터넷 참고)
            result.sdata = Convert.ToString(result.fdata);          //ToString(float) 문자열 반환 

            result.idata = int.Parse(s1);                           // Parse(String)  정수 값을 반환
            result.fdata = result.idata;                            // (float) = (int) 대입시 묵식적 형변환 발생
            result.sdata = String.Format("{0:F2}" , result.fdata);  // String.Format("{0:F2}" , result.fdata) , system.console.writeline("{0:F2}" , result.fdata) 포멧 유형 

            //변순 선언 초기화(default) 
            int idata = default(int);                               //default(int) int 자료형의 초기값 0
            float fdata = default(float);                           //default(float) float 자료형의 초기값
            string sdata ;                                          //String = NULL 비초기화 

            int.TryParse(s1, out idata);                            //TryParse(실패 , out 성공) 실패시 앞에 변수(문자열) , 성공시((int)반환값) 사용 이유 문자열 숫자가 아닌값 넣으면 에러가 발생되지만 이 메서드를 사용하면 실패시 문자열 반환하여 에러가 안나옴! - 예외처리( 인터넷 참고 )
            fdata = (float)result.idata;                            //명시적 형변환
            sdata = new StringBuilder().Append(fdata).ToString();   //String , StringBuilder 차이점 String 매회할당 , StringBuilder 1회 할당 (단 문자열이 계속 변경된다면 불이익)
            sdata = fdata +"";                                      //묵시적 형변환 (float) + (String) = (String)

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
