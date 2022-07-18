namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19
{
    public class Program
    {
        public static void Main()
        {
            int? age;

            //...

            // Clear the value of age
            age = null;

            //...

            System.Console.WriteLine($"The age is: {age}");  
        }
    }
}

//** int? age  int에 널값은 들어갈 수 없지만 null을 넣을 수 있음 (신기하네)