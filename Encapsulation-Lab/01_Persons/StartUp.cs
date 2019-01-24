using System;
using System.Collections.Generic;
using System.Linq;

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
                persons.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2])));
            }

            persons
                .OrderBy(x => x.FirstName + ' ' + x.LastName)
                .ThenBy(x => x.Age).ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
