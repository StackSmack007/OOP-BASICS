using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                persons.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3])));
            }
            decimal raisePercentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(x => x.IncreaseSalary(raisePercentage));
            persons.ForEach(x => Console.WriteLine(x));
        }
    }
}