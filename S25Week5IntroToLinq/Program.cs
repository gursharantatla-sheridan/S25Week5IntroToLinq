namespace S25Week5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 5, 7, 6, 5, 8, 9, 1, 4, 5, 7, 3 };

            var greaterThan4 = from num in array
                               where num > 4
                               select num;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");
        }
    }
}
