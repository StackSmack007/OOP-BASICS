using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Google
{
    class Program
    {
        static void Main()
        {
            string[] input;
            List<Person> persons = new List<Person>();
            while ((input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                string personName = input[0];
                int index = persons.FindIndex(x => x.Name == personName);
                if (index == -1)
                {
                    index = persons.Count;
                    persons.Add(new Person(personName));
                }

                switch (input[1].ToLower())
                {
                    case "pokemon": persons[index].Pokemons.Add(new Pokemon(input)); break;
                    case "children": case "parents": persons[index].FamilyMembers.Add(new FamilyMember(input)); break;
                    case "car": persons[index].Car = new Car(input); break;
                    case "company": persons[index].Company = new Company(input); break;
                }
            }
            string request = Console.ReadLine();
          persons.FirstOrDefault(x => x.Name == request).Print();
        }
    }
}