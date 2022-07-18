namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
                $"Your full name is { firstName } { lastName }.");
            //앞에 $ 가 있어야지만 { } 안에 값을 변수로 봄 !!!
            System.Console.WriteLine(firstName);
            //단일로 쓰기
        }
    }
}
