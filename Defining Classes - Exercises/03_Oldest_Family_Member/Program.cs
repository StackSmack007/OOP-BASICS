using System;

namespace nameSpace03
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
            Person winner = family.GetOldest();
            Console.WriteLine($"{winner.Name} {winner.Age}");
        }
    }
}