using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_Family_Tree
{
    class Program
    {
        static void Main()
        {
            List<Person> family = new List<Person>();

            List<string[]> commands = new List<string[]>();
            string input = Console.ReadLine();
            if (input.Split().Length == 2)
            {
                family.Add(MakeBlankName(input));
            }
            else
            {
                family.Add(MakeBlankBirthDay(input));
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr;
                if (!input.Contains('-'))
                {
                    inputArr = input.Split();
                    string names = inputArr[0] + " " + inputArr[1];
                    string birthDate = inputArr[2];
                    int index = Math.Max(family.FindIndex(x => x.Names == names), family.FindIndex(x => x.BirthDate == birthDate));
                    if (index == -1)
                    {
                        family.Add(new Person(names, birthDate));
                    }
                    else
                    {
                        foreach (Person person in family.Where(x=>x.Names==names||x.BirthDate==birthDate))
                        {
                            person.Names=names;
                            person.BirthDate = birthDate;
                        }
                    }
                }
                else
                {
                    inputArr = input.Split('-').Select(x => x.Trim()).ToArray();
                    commands.Add(inputArr);//Only in case we have relation set by "-"
                    string leftData = inputArr[0];
                    string rightData = inputArr[1];
                    RegisterNew(family, leftData);
                    RegisterNew(family, rightData);
                }
            }
            family = family.GroupBy(x => x.Names).Select(x=>x.First()).ToList();
            Person target = family.First();
            family.RemoveAt(0);
            
            foreach (string[] command in commands)
            {
                string leftData = command[0];

                string rightData = command[1];

                if (leftData == target.BirthDate || leftData == target.Names)
                {
                    int index = Math.Max(family.FindIndex(x => x.Names == rightData), family.FindIndex(x => x.BirthDate == rightData));
                    if (index != -1)
                    {
                        family[index].Status = "child";
                    }
                }
                else if (rightData == target.BirthDate || rightData == target.Names)
                {
                    int index = Math.Max(family.FindIndex(x => x.Names == leftData), family.FindIndex(x => x.BirthDate == leftData));
                    if (index != -1)
                    {
                        family[index].Status = "parent";
                    }
                }
            }

            Console.WriteLine($"{target.Names} {target.BirthDate}");
            Console.WriteLine("Parents:");
            foreach (Person member in family.Where(x => x.Status == "parent"))
            {
                Console.WriteLine($"{member.Names} {member.BirthDate}");
            }
            Console.WriteLine("Children:");
            foreach (Person member in family.Where(x => x.Status == "child"))
            {
                Console.WriteLine($"{member.Names} {member.BirthDate}");
            }
        }

        static Person MakeBlankBirthDay(string birthDay)
        {
            return new Person()
            {
                BirthDate = birthDay
            };
        }

        static Person MakeBlankName(string name)
        {
            return new Person(name);
        }

        static void RegisterNew(List<Person> family, string input)
        {
            bool isDate = input.Contains("/");
            if (isDate && !family.Any(x => x.BirthDate == input))
            {
                family.Add(MakeBlankBirthDay(input));
            }
            else if (!isDate && !family.Any(x => x.Names == input))
            {
                family.Add(MakeBlankName(input));
            }




        }
     
    }
}