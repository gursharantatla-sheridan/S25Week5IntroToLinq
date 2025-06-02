namespace S25Week5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 5, 7, 6, 5, 8, 9, 1, 4, 5, 7, 3 };

            // query syntax
            var greaterThan4 = from num in array
                               where num > 4
                               orderby num
                               select num;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


            // method syntax
            var greaterThan5 = array.Where(n => n > 5).OrderBy(n => n).ToList();

            foreach (var i in greaterThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("rUSt");
            colors.Add("GreEn");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppercaseStr = c.ToUpper()
                              where uppercaseStr.StartsWith("R")
                              orderby uppercaseStr
                              select uppercaseStr;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUBy");
            colors.Add("PiNk");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");
        }
    }
}
