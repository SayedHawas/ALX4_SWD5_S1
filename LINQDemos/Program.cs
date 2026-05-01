namespace LINQDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
                1)Implicit type (Var)            Done
                2)Object Initializer.            Done
                3)Collection Initializer.        Done
                4)Dynamic Name.                  Done
                5)Anonymous Object               Done
                6)Anonymous Types.               Done
                7)Generic type.                  Done
                8)Generic Interface              Done
                9)Extension Methods.             Done
            
             */

            //SOLID Principles
            //S: Single Responsibility Principle
            //O: Open-Closed Principle

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var p = new Person(1, "Ali", 25); //{ Id = 1, Name = "Ahmed", Age = 30 };

            //Anonymous Object     
            new Person { Id = 2, Name = "Mariem", Age = 21 };



            List<Person> people = new List<Person>(){
            new Person { Id = 1, Name = "Ahmed", Age = 21 },
            new Person { Id = 2, Name = "Mariem", Age = 21 },
            new Person { Id = 3, Name = "Yasser", Age = 21 },
            };

            var selectItem = from pp in people
                             where pp.Age > 20
                             select new { pp.Id, pp.Name };


            // Indexer 0 , 1 , 2, 3, 4, 5
            //Collection Initializer
            people.Add(p);

            string str = "Smart software";
            Console.WriteLine(str.Length);

            dynamic x = 50;
            Console.WriteLine(x.Length);
            // var xx = employees.Where( e=>e.Age >50);

            //Anonymous Types. 
            var y = new { Id = 1, Name = "Ahmed", Salary = 15000 };
            //y.Id = 2; //Error because the properties of anonymous types are read-only

            int Number = 100;
            Number.Add(50);
            int N1 = MyMath.Add(200, 50);

        }
    }

    public class Person
    {
        public Person()
        {

        }
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public static class MyMath //:Int32
    {
        static MyMath()
        {
            //this  
        }

        public static int Add(this int number, int value)
        {
            return number + value;
        }
    }
}
