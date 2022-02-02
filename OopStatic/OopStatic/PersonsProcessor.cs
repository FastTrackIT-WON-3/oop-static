using System;

namespace OopStatic
{
    public static class PersonsProcessor
    {
        public static void PrintIfPersonIsAdult(Person p)
        {
            if (p.Age > 18)
            {
                Console.WriteLine($"Person is adult: {p.FirstName} {p.LastName}, age: {p.Age}");
            }
            else
            {
                Console.WriteLine($"Person is NOT adult");
            }
        }
    }
}
