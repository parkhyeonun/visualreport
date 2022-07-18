namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{
    namespace Chapter03
    {
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "Second" })]
        public System.ValueTuple<string, string> ParseNames(string fullName)
        {
            // ...
        }
    
    /*
        public static void Main()
        {
            (string First, string Second, string Third) namedFruits = ("apple", "orange", "bananna");
            namedFruits.First = "Eat";
            System.Console.WriteLine(namedFruits.First);

        }
    */
    }

}
//튜플형식 이넘클래스와 비슷해보이지만 뭔가다름