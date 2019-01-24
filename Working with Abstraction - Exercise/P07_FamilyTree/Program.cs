using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            string mainPersonData = Console.ReadLine();
            List<string[]> relations = new List<string[]>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains('-'))
                {
                    relations.Add(input.Split('-').Select(x => x.Trim()).ToArray());
                    continue;
                }
                string[] tokens = input.Split().Select(x => x.Trim()).ToArray();
                persons.Add(new Person(tokens[0]+' '+ tokens[1], tokens[2]));
            }
            foreach (string[] relation in relations)
            {
                Person parent = GetPerson(persons, relation[0]);
                Person child = GetPerson(persons, relation[1]);
                parent.Children.Add(child);
                child.Parents.Add(parent);
            }
            GetPerson(persons, mainPersonData).PrintData();
        }
        static bool IsDate(string input)
        {
            if (input.Contains('/'))
            {
                return true;
            }
            return false;
        }

        static Person GetPerson(List<Person> persons,string input)
        {
            if (IsDate(input))
            {
                return persons.FirstOrDefault(x => x.Birthday == input);
            }
            return persons.FirstOrDefault(x => x.Name == input);
        }
    }
}