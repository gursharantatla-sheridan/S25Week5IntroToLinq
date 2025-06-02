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



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Greene", 5000),
                new Employee("Carrie", "Indigo", 3000),
                new Employee("Anne", "Indigo", 4000),
                new Employee("James", "Brown", 6000),
                new Employee("Matt", "Indigo", 5500),
                new Employee("Lucy", "White", 7000)
            };

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var lastnames = (from e in employees
                            select e.LastName).Distinct();

            foreach (var emp in lastnames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");
        }
    }
}
