using System;

namespace OopStatic
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public int Age;

        public static int PopulationCount = 0;

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is: {this.FirstName} {this.LastName}");
            Console.WriteLine($"Current population count: {Person.PopulationCount}");

            PersonsProcessor.PrintIfPersonIsAdult(this);
        }

        public static void PrintPopulationCount()
        {
            Console.WriteLine($"Right now there are {Person.PopulationCount} persons living in this app");
        }
    }
}
