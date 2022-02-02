using System;

namespace OopStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person.PopulationCount = 1;

            p.FirstName = "John";
            p.LastName = "Doe";
            p.Age = 35;
            p.SayHello();

            Person.PrintPopulationCount();

        }
    }
}
