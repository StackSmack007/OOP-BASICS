using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Company_Roster
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> employeesRegister = new Dictionary<string, List<Employee>>();
            for (int i = 0; i < n; i++)
            {
                Employee currentEmployee = new Employee();
                string[] tokens = Console.ReadLine().Split(' ');
                int age;
                string departament = tokens[3];
                if (!employeesRegister.ContainsKey(departament))
                {
                    employeesRegister[departament] = new List<Employee>();
                }
                if (tokens.Length == 5)
                {
                    if (int.TryParse(tokens[4], out age))
                    {
                        currentEmployee = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], age);
                    }
                    else
                    {
                        currentEmployee = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], tokens[4]);
                    }
                }
                if (tokens.Length == 6)
                {
                    currentEmployee = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], tokens[4], int.Parse(tokens[5]));
                }
                if (tokens.Length == 4)
                {
                    currentEmployee = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3]);
                }

                employeesRegister[departament].Add(currentEmployee);
            }
            var topDepartment = employeesRegister.OrderByDescending(x => x.Value.Sum(y => y.Salary) / x.Value.Count).First();
            Console.WriteLine("Highest Average Salary: {0}",topDepartment.Key);
            foreach (var person in topDepartment.Value.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{person.Name} {person.Salary:F2} {person.Email} {person.Age}");
            }
            //      Define a class Employee that holds the following information:
            //      name, salary, position, department, email and age.
            //      The name, salary, position and department are mandatory while the rest are optional.
        }
    }
}
