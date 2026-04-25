using ClassLibraryDemo;
namespace ConsoleDome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //API
            Helper helper = new Helper();
            string message = helper.GetMessage("Hello from ConsoleDome!");


            //Anonymous Object 
            person p = new person() { Id = 1, Name = "John" };

            new person() { Id = 2, Name = "Jane" };

            List<person> people = new List<person>()
            {
                new person() { Id = 1, Name = "John" },
                new person() { Id = 2, Name = "Jane" }
            };

            //Modify Code 

            //people[0]
            //Anonymous Type
            var Employee = new { Id = 1, Name = "Ahmed", Job = "Developer" };
            // Employee.Id = 2; // This line would cause a compile-time error because anonymous types are immutable
            Console.WriteLine(Employee.Name);

            Console.ReadLine();
        }
    }

    class person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
