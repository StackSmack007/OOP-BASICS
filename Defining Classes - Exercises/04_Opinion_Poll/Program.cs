using System;
using System.Collections.Generic;

namespace _04_Opinion_Poll
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                family.AddPerson(Console.ReadLine());
            }
            List<Person> agedOnes = family.GetOlderThan30();
            foreach (Person winner in agedOnes)
            {
                Console.WriteLine($"{winner.Name} - {winner.Age}");
            }
        }
    }
}