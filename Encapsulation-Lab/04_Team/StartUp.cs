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
                try
                {
                    persons.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3])));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Team dreamTeam = new Team("SoftUni");
            persons.ForEach(p => dreamTeam.AddPlayer(p));
            Console.WriteLine("First team has {0} players.", dreamTeam.FirstTeam.Count);
            Console.WriteLine("Reserve team has {0} players.", dreamTeam.ReserveTeam.Count);
        }
    }
}