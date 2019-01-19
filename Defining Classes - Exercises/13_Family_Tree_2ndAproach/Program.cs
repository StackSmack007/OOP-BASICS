using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_Family_Tree_2ndAproach
{
    class Program
    {
        static void Main()
        {
            List<string> relations = new List<string>();
            List<Person> persons = new List<Person>();
            Person mainPerson = new Person()
            {
                Children = new List<Person>(),
                Parents = new List<Person>()
            };

            string input = Console.ReadLine();

            if (input.Split().Length == 1)
            {
                mainPerson.BirthDate = input;
            }
            else
            {
                mainPerson.Names = input;
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains('-'))
                {
                    relations.Add(input);
                    continue;
                }

                string[] inputArr = input.Split().Select(x => x.Trim()).ToArray();
                string names = inputArr[0] + " " + inputArr[1];
                string birthDay = inputArr[2];

                if (IsMainPerson(mainPerson, names) || IsMainPerson(mainPerson, birthDay))
                {
                    mainPerson.Names = names;
                    mainPerson.BirthDate = birthDay; continue;
                }
                persons.Add(new Person(names, birthDay));
            }

            foreach (string relation in relations)
            {
                string[] inputArr = relation.Split('-').Select(x => x.Trim()).ToArray();
                string left = inputArr[0];
                string right = inputArr[1];

                if (IsMainPerson(mainPerson, left))
                {
                    int index = GetId(persons, right);
                    if (index == -1) continue;
                    mainPerson.Children.Add(persons[index]);
                }
                else if (IsMainPerson(mainPerson, right))
                {
                    int index = GetId(persons, left);
                    if (index == -1) continue;
                    mainPerson.Parents.Add(persons[index]);
                }
            }

            Console.WriteLine($"{mainPerson.Names} {mainPerson.BirthDate}");
            Console.WriteLine("Parents:");
            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Names} {parent.BirthDate}");
            }

            Console.WriteLine("Children:");
            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Names} {child.BirthDate}");
            }
        }

        static bool IsMainPerson(Person person, string potentialMatch)
        {
            if (person.Names == potentialMatch || person.BirthDate == potentialMatch)
            {
                return true;
            }
            return false;
        }

        static int GetId(List<Person> persons, string potentialMatch)
        {
            return persons.FindIndex(x => x.Names == potentialMatch || x.BirthDate == potentialMatch);
        }
    }
}